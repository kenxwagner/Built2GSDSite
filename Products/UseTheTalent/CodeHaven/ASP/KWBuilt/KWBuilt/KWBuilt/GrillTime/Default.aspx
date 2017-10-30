<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
        }
        .style2
        {
            width: 550px;
            height: 520px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to a great grill website!</h2>
    <p class="style1">
        Whether it&#39;s Weber or Traeger find out ratings tips and 
        links!</p>
    <p>
        <img alt="Traeger Grill Gif" class="style2" 
            longdesc="Traeger Grill mult-view animated gif" 
            src="Images/Traeger-Grill-1-blackback.jpg" /></p>
</asp:Content>
