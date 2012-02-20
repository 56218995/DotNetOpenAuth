﻿//-----------------------------------------------------------------------
// <copyright file="PerformanceTests.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Test.OpenId.Provider {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.Messaging.Reflection;
	using DotNetOpenAuth.OpenId;
	using DotNetOpenAuth.OpenId.ChannelElements;
	using DotNetOpenAuth.OpenId.Messages;
	using DotNetOpenAuth.OpenId.Provider;
	using DotNetOpenAuth.Test.Performance;
	using NUnit.Framework;

	[TestFixture, Category("Performance")]
	public class PerformanceTests : OpenIdTestBase {
		private const string SharedAssociationHandle = "handle";
		private static readonly TimeSpan TestRunTime = TimeSpan.FromSeconds(3);
		private OpenIdProvider provider;

		[SetUp]
		public override void SetUp() {
			base.SetUp();
			this.provider = CreateProvider();
		}

		[TestCase]
		public void AssociateDH() {
			var associateRequest = this.CreateAssociateRequest(OPUri);
			MeasurePerformance(
				() => {
					IRequest request = this.provider.GetRequest(associateRequest);
					var response = this.provider.PrepareResponse(request);
					Assert.IsInstanceOf<AssociateSuccessfulResponse>(response.OriginalMessage);
				},
				maximumAllowedUnitTime: 3.5e6f,
				iterations: 1);
		}

		[TestCase]
		public void AssociateClearText() {
			var associateRequest = this.CreateAssociateRequest(OPUriSsl); // SSL will cause a plaintext association
			MeasurePerformance(
				() => {
					IRequest request = this.provider.GetRequest(associateRequest);
					var response = this.provider.PrepareResponse(request);
					Assert.IsInstanceOf<AssociateSuccessfulResponse>(response.OriginalMessage);
				},
				maximumAllowedUnitTime: 1.5e4f,
				iterations: 1000);
		}

		[TestCase]
		public void CheckIdSharedHmacSha1Association() {
			Protocol protocol = Protocol.Default;
			string assocType = protocol.Args.SignatureAlgorithm.HMAC_SHA1;
			this.ParameterizedCheckIdTest(protocol, assocType);
		}

		[TestCase]
		public void CheckIdSharedHmacSha256Association() {
			Protocol protocol = Protocol.Default;
			string assocType = protocol.Args.SignatureAlgorithm.HMAC_SHA256;
			this.ParameterizedCheckIdTest(protocol, assocType);
		}

		private void ParameterizedCheckIdTest(Protocol protocol, string assocType) {
			Association assoc = HmacShaAssociationProvider.Create(
				protocol,
				assocType,
				AssociationRelyingPartyType.Smart,
				this.provider.AssociationStore,
				this.provider.SecuritySettings);
			var checkidRequest = this.CreateCheckIdRequest(true);
			MeasurePerformance(
				() => {
					var request = (IAuthenticationRequest)this.provider.GetRequest(checkidRequest);
					request.IsAuthenticated = true;
					var response = this.provider.PrepareResponse(request);
					Assert.IsInstanceOf<PositiveAssertionResponse>(response.OriginalMessage);
				},
				maximumAllowedUnitTime: 6.8e4f);
		}

		private HttpRequestInfo CreateAssociateRequest(Uri opEndpoint) {
			var rp = CreateRelyingParty(true);
			AssociateRequest associateMessage = AssociateRequestRelyingParty.Create(rp.SecuritySettings, new ProviderEndpointDescription(opEndpoint, Protocol.Default.Version));
			Channel rpChannel = rp.Channel;
			MemoryStream ms = new MemoryStream();
			StreamWriter mswriter = new StreamWriter(ms);
			mswriter.Write(MessagingUtilities.CreateQueryString(rpChannel.MessageDescriptions.GetAccessor(associateMessage)));
			mswriter.Flush();
			ms.Position = 0;
			var headers = new WebHeaderCollection();
			headers.Add(HttpRequestHeader.ContentType, Channel.HttpFormUrlEncoded);
			var httpRequest = new HttpRequestInfo("POST", opEndpoint, opEndpoint.PathAndQuery, headers, ms);
			return httpRequest;
		}

		private HttpRequestInfo CreateCheckIdRequest(bool sharedAssociation) {
			var rp = CreateRelyingParty(true);
			CheckIdRequest checkidMessage = new CheckIdRequest(
				Protocol.Default.Version,
				OPUri,
				DotNetOpenAuth.OpenId.AuthenticationRequestMode.Setup);
			if (sharedAssociation) {
				checkidMessage.AssociationHandle = SharedAssociationHandle;
			}
			checkidMessage.ClaimedIdentifier = OPLocalIdentifiers[0];
			checkidMessage.LocalIdentifier = OPLocalIdentifiers[0];
			checkidMessage.Realm = RPRealmUri;
			checkidMessage.ReturnTo = RPUri;
			Channel rpChannel = rp.Channel;
			UriBuilder receiver = new UriBuilder(OPUri);
			receiver.Query = MessagingUtilities.CreateQueryString(rpChannel.MessageDescriptions.GetAccessor(checkidMessage));
			var headers = new WebHeaderCollection();
			var httpRequest = new HttpRequestInfo("GET", receiver.Uri, receiver.Uri.PathAndQuery, headers, null);
			return httpRequest;
		}
	}
}
