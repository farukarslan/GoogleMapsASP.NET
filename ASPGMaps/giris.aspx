<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="ASPGMaps.giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <dl>
        <dt>Bölge giriniz:</dt>
        <dd><asp:TextBox ID="TextBoxbolge" runat="server"></asp:TextBox></dd>
        
        <dt>Mekan ismi giriniz</dt>
        <dd><asp:TextBox ID="TextBoxmekan" runat="server"></asp:TextBox></dd>

        <dt>Enlem giriniz:</dt>
        <dd><asp:TextBox ID="TextBoxenlem" runat="server"></asp:TextBox></dd>

        <dt>Boylam giriniz:</dt>
        <dd><asp:TextBox ID="TextBoxboylam" runat="server"></asp:TextBox></dd>

        <dt>Site ismi giriniz:</dt>
        <dd><asp:TextBox ID="TextBoxsite" runat="server"></asp:TextBox></dd>

        <dt>Kayıt için tıklayınız:</dt>
        <dd><asp:Button ID="Button1" runat="server" Text="Kayet" OnClick="Button1_Click" /></dd>
    </dl>
</asp:Content>
