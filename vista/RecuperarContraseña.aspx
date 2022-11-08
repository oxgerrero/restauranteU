<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MaestraSinLogin.master" AutoEventWireup="true" CodeFile="~/controlador/RecuperarContraseña.aspx.cs" Inherits="vista_RecuperarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Nueva Contraseña:</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Width="163px"></asp:TextBox>
    </p>
    <p>
        Confirmar Contraseña:</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Width="161px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="GUARDAR" />
    </p>
</asp:Content>

