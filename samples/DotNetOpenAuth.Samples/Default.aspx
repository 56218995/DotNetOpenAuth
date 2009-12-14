<%@ Page Title="" Language="C#" MasterPageFile="~/master/SampleSite.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="DotNetOpenAuth.Samples.Default" %>
<%@ MasterType VirtualPath="~/master/SampleSite.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentHolder" runat="server">
  <h1>
        Welcome</h1>
    <p>
        This is a directory of all the sample web applications that have been created for you to assist with your understanding and integration of the DotNetOpenAuth library.    </p>
    <h2>
        Sample Applications - Overview</h2>
    <p>We have created sample applications for a number of different scenarios so we are confident that you will find one that suits your needs.    </p>
    <h3>Samples Available</h3>
    <div style="width:40%;float:left;border-right:2px dotted #cecece;padding:10px;">
      <h4>ASP.NET WebForms</h4>
      <h5>OpenID Samples</h5>
      <ul>
        <li>Relying Party Sample</li>
        <li>Provider Sample</li>
        <li><a href="OpenIDSamples.aspx">View  Details</a></li>
      </ul>
      <h5>OAuth Samples</h5>
      <ul>
        <li>Consumer Sample</li>
        <li>Service Provider Sample        </li>
        <li><a href="OAuthSamples.aspx">View  Details</a></li>
      </ul>
      <h5>Other  Samples</h5>
      <ul>
        <li>Information Card Relying Party Sample</li>
        <li>Classic ASP (COM+) Sample</li>
        <li><a href="OtherSamples.aspx">View  Details</a></li>
      </ul>
  </div>
    <div style="width:40%;float:left;margin-left:10px;padding:10px;">
     	<h4>ASP.NET MVC</h4>
        <h5>OpenID Samples</h5>
        <ul>
        	<li> Relying Party Sample</li>
        	<li>Provider Sample</li>
        	<li><a href="OpenIDSamples.aspx">View  Details</a></li>
		</ul>
    </div>    
    <br style="clear:both" />
</asp:Content>
