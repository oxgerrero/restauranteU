<%@ Page Title="" Language="C#" MasterPageFile="~/vista/maestraLogin.master" AutoEventWireup="true" CodeFile="~/controlador/insertarAdmin.aspx.cs" Inherits="vista_insertarAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_usuario" runat="server">
        usuario<br /> nombre<asp:TextBox ID="TB_nombre" runat="server"></asp:TextBox>
        <br />
        usuario<asp:TextBox ID="TB_usuario" runat="server"></asp:TextBox>
        <br />
        contraseña<asp:TextBox ID="TB_contraseña" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        telefono<asp:TextBox ID="TB_telefono" runat="server" TextMode="Phone"></asp:TextBox>
        <br />
        correo
        <asp:TextBox ID="TB_correo" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        identificacion<asp:TextBox ID="TB_identificacion" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        estado<asp:DropDownList ID="DDL_estado" runat="server">
            <asp:ListItem Value="1">Activo</asp:ListItem>
            <asp:ListItem Value="2">Inactivo</asp:ListItem>
        </asp:DropDownList>
        <br />
        rol<asp:DropDownList ID="DDL_rol" runat="server">
            <asp:ListItem Value="1">Administrador</asp:ListItem>
            <asp:ListItem Value="2">Estudiante</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="B_insertar" runat="server" OnClick="B_insertar_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_estado" runat="server">
        estado</asp:Panel>
    <asp:Panel ID="P_rol" runat="server">
        rol</asp:Panel>
    <asp:Panel ID="P_restaurante" runat="server">
        restaurante</asp:Panel>
    <asp:Panel ID="P_menu" runat="server">
        menu</asp:Panel>
</asp:Content>

