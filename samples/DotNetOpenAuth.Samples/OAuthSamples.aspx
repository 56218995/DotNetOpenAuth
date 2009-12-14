
<%@ Page Title="" Language="C#" MasterPageFile="~/master/SampleSite.Master" AutoEventWireup="true" CodeBehind="OAuthSamples.aspx.cs" Inherits="DotNetOpenAuth.Samples.OAuthSamples" %>
<%@ MasterType VirtualPath="~/master/SampleSite.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RelatedLinksContentHolder" runat="server">
<ul>
    <li><a href="OAuthConsumer/">Consumer Demo</a></li>
    <li><a href="OAuthProvider/">Provider Demo</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentHolder" runat="server">
<h1>OAuth</h1>
<p><strong><img src="images/180px-Oauth_logo.svg.png" alt="OAuthLogo" width="100" hspace="10" /></strong></p>
<h2>What is OAuth</h2>
<p><strong>OAuth</strong> is an open protocol that allows users to share their private resources (e.g. photos, videos, contact lists) stored on one site with another site without having to hand out their username and password.</p>
<p>OAuth allows users to hand out tokens instead of usernames and passwords to their data hosted by a given service provider. Each token grants access to a specific site (e.g. a video editing site) for specific resources (e.g. just videos from a specific album) and for a defined duration (e.g. the next 2 hours).</p>
<p>Thus OAuth allows a user to grant a third party site access to their information stored with another service provider, without sharing their access permissions or the full extent of their data.</p>
<p>It is analogous to using a credit card and signing for a transaction in a restaurant, rather than handing over your ATM card and giving your pin to the waiter.</p>
<p>OAuth is a complementary but distinct service to OpenId.</p>
</asp:Content>
