<%@ Page Title="" Language="C#" MasterPageFile="~/master/SampleSite.Master" AutoEventWireup="true" CodeBehind="OpenIDSamples.aspx.cs" Inherits="DotNetOpenAuth.Samples.OpenIDSamples" %>
<%@ MasterType VirtualPath="~/master/SampleSite.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RelatedLinksContentHolder" runat="server">
<h2>ASP.NET WebForms</h2>
<ul>
    <li><a href="OpenIDRP/">Information Card RP</a></li>
    <li><a href="OpenIDProvider/">Classic ASP</a></li>
</ul>
<h2>ASP.NET MVC</h2>
<ul>
    <li><a href="OpenIDRPMVC/">Information Card RP</a></li>
    <li><a href="OpenIDProviderMVC/">Classic ASP</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentHolder" runat="server">
<h1>OpenID</h1>
<p><img src="images/openid.jpg" alt="OpenIDLogo" width="200" /></p>
<h2>What is OpenID? </h2>
<p>OpenID is an open, decentralized standard for authenticating users which can be used for access control, allowing users to log on to different services with the same digital identity where these services trust the authentication body. OpenID replaces the common login process that uses a login-name and a password, by allowing a user to log in once and gain access to the resources of multiple software systems. The term OpenID can also refer to an ID used in the standard.</p>
</asp:Content>
