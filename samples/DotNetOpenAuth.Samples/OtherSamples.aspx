<%@ Page Title="" Language="C#" MasterPageFile="~/master/SampleSite.Master" AutoEventWireup="true" CodeBehind="OtherSamples.aspx.cs" Inherits="DotNetOpenAuth.Samples.OtherSamples" %>
<%@ MasterType VirtualPath="~/master/SampleSite.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RelatedLinksContentHolder" runat="server">
<ul>
    <li><a href="InfoCardRP/">Information Card RP</a></li>
    <li><a href="ClassicASP/">Classic ASP</a></li>
</ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentHolder" runat="server">
<h1>Other Samples</h1>
<p>We have developed a number of additional samples to demonstrate the capabilities of DotNetOpenAuth.</p>
</asp:Content>
