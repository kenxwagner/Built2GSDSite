<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="left">First Name <asp:TextBox ID="TextBox1" runat="server" 
            BackColor="White"></asp:TextBox>  &nbsp;&nbsp;&nbsp;&nbsp; Last Name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        E-mail  
        <asp:TextBox ID="TextBox3" runat="server" Width="129px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Address:  <asp:TextBox ID="TextBox4" runat="server" Width="148px"></asp:TextBox>
    &nbsp;<br />
        City:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Country:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        Shoe style:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;Shoe Size:&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;Color:&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp; Pattern:&nbsp;
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp; Qty:
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
    </div>
&nbsp;
</asp:Content>

