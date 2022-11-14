<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MaestraSinLogin.master" AutoEventWireup="true" CodeFile="~/controlador/registro.aspx.cs" Inherits="vista_registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Nombre:</p>
    <p>
        <asp:TextBox ID="TB_nombre" runat="server" Width="190px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Usuario:</p>
    <asp:TextBox ID="TB_usuario" runat="server" Width="190px"></asp:TextBox>
<p>
    Contraseña:</p>
<p>
    <asp:TextBox ID="TB_contraseña1" runat="server" TextMode="Password" Width="190px"></asp:TextBox>
</p>
    <p>
        Confirmar Contraseña:</p>
    <p>
        <asp:TextBox ID="TB_contraseña2" runat="server" TextMode="Password" Width="190px"></asp:TextBox>
</p>
    <p>
        Telefono:</p>
    <p>
        <asp:TextBox ID="TB_telefono" runat="server" TextMode="Phone" Width="190px"></asp:TextBox>
</p>
    <p>
        Correo:</p>
    <p>
        <asp:TextBox ID="TB_correo" runat="server" TextMode="Email" Width="190px"></asp:TextBox>
</p>
    <p>
        Identificacion:</p>
    <p>
        <asp:TextBox ID="TB_identificacion" runat="server" Width="190px"></asp:TextBox>
    </p>
<p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrarse" style="margin-left: 42px" Width="103px" />
    </p>
</asp:Content>

