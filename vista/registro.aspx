<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MaestraSinLogin.master" AutoEventWireup="true" CodeFile="~/controlador/registro.aspx.cs" Inherits="vista_registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Nombre:<asp:TextBox ID="TB_nombre" runat="server"></asp:TextBox>
</p>
<p>
    Usuario:<asp:TextBox ID="TB_usuario" runat="server"></asp:TextBox>
</p>
<p>
    contraseña:<asp:TextBox ID="TB_contraseña1" runat="server"></asp:TextBox>
</p>
<p>
    confirmar contraseña:<asp:TextBox ID="TB_contraseña2" runat="server"></asp:TextBox>
</p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrarse" />
<p>
    &nbsp;</p>
</asp:Content>

