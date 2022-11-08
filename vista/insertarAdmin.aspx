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
        estado<br /> Descripcion
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_rol" runat="server">
        rol<br /> Descripcion
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_restaurante" runat="server">
        Asistencia<br /> identificacion Usuario<asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        tipo<asp:DropDownList ID="DDL_tipoComida" runat="server">
            <asp:ListItem Value="1">Desayuno</asp:ListItem>
            <asp:ListItem Value="2">Almuerzo</asp:ListItem>
            <asp:ListItem Value="3">Cena</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_tipoMenu" runat="server">
        Tipo menu<br />
        tipo<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">Desayuno</asp:ListItem>
            <asp:ListItem Value="2">Almuerzo</asp:ListItem>
            <asp:ListItem Value="3">Cena</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_menu" runat="server">
        menu<br /> fecha<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        tipo menu
        <asp:DropDownList ID="DDL_tipoComida0" runat="server">
            <asp:ListItem Value="1">Desayuno</asp:ListItem>
            <asp:ListItem Value="2">Almuerzo</asp:ListItem>
            <asp:ListItem Value="3">Cena</asp:ListItem>
        </asp:DropDownList>
        <br />
        Menu
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Insertar" />
    </asp:Panel>
</asp:Content>

