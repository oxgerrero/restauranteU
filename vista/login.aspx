<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MaestraSinLogin.master" AutoEventWireup="true" CodeFile="~/controlador/login.aspx.cs" Inherits="vista_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Usuario</p>
    <p>
        <asp:TextBox ID="TB_username" runat="server"></asp:TextBox>
    </p>
    <p>
        Contraseña</p>
    <p>
        <asp:TextBox ID="TB_password" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="B_ingresar" runat="server" OnClick="B_ingresar_Click" Text="Ingresar" />
    </p>
</asp:Content>

