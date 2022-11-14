<%@ Page Title="" Language="C#" MasterPageFile="~/vista/maestraLogin.master" AutoEventWireup="true" CodeFile="~/controlador/insertarAdmin.aspx.cs" Inherits="vista_insertarAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="P_usuario" runat="server">
        usuario<br /> <br /> Nombre:<br />
        <asp:TextBox ID="TB_nombre" runat="server" style="margin-bottom: 0px" Width="170px"></asp:TextBox>
        <br />
        <br />
        Usuario:<br />
        <asp:TextBox ID="TB_usuario" runat="server" style="margin-top: 0px" Width="170px"></asp:TextBox>
        <br />
        <br />
        Contraseña:<br />
        <asp:TextBox ID="TB_contraseña" runat="server" style="margin-bottom: 0px" TextMode="Password" Width="170px"></asp:TextBox>
        <br />
        <br />
        Telefono:<br />
        <asp:TextBox ID="TB_telefono" runat="server" TextMode="Phone" Width="170px"></asp:TextBox>
        <br />
        <br />
        <br />
        Correo:
        <br />
        <asp:TextBox ID="TB_correo" runat="server" TextMode="Email" Width="170px"></asp:TextBox>
        <br />
        <br />
        Identificacion:<br />
        <asp:TextBox ID="TB_identificacion" runat="server" TextMode="Number" Width="170px"></asp:TextBox>
        <br />
        <br />
        Estado&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DDL_estado" runat="server" Height="17px" Width="85px" DataSourceID="ODS_estadosAdmin" DataTextField="Nombre" DataValueField="Id_estado">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ODS_estadosAdmin" runat="server" SelectMethod="datos_estadosAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <br />
        <br />
        <br />
        Rol&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DDL_rol" runat="server" Height="16px" Width="114px" DataSourceID="ODS_rolesAdmin" DataTextField="Nombre" DataValueField="Id_rol">
            <asp:ListItem Value="1">Administrador</asp:ListItem>
            <asp:ListItem Value="2">Estudiante</asp:ListItem>
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ODS_rolesAdmin" runat="server" SelectMethod="datos_rolAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <br />
        <br />
        <br />
        <asp:Button ID="B_insertar" runat="server" OnClick="B_insertar_Click" Text="Insertar" style="margin-left: 78px" Width="85px" />
    </asp:Panel>
    <asp:Panel ID="P_estado" runat="server">
        Estado:<br /> Descripcion
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_rol" runat="server">
        Rol:<br /> Descripcion<br /> &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_Asistencia" runat="server">
        Asistencia<br /> Restaurante<br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ODS_restaurantesAdmin" DataTextField="Nombre" DataValueField="Id_restaurante">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ODS_restaurantesAdmin" runat="server" SelectMethod="datos_restauranteAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <br /> identificacion Usuario<br /> <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Tipo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DDL_tipoComida" runat="server" DataSourceID="ODS_tipoMenu" DataTextField="descripcion" DataValueField="id_tipo">
            <asp:ListItem Value="1">Desayuno</asp:ListItem>
            <asp:ListItem Value="2">Almuerzo</asp:ListItem>
            <asp:ListItem Value="3">Cena</asp:ListItem>
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ODS_tipoMenu" runat="server" SelectMethod="datos_tipoMenu" TypeName="Usuarios"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_tipoMenu" runat="server">
        Tipo menu<br /> <br />
        Tipo&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
    </asp:Panel>
    <asp:Panel ID="P_menu" runat="server">
        MENU<br />
        <br />
        Fecha<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        Tipo Menu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDL_tipoComida0" runat="server" DataSourceID="ODS_tipoMenu" DataTextField="descripcion" DataValueField="id_tipo">
            <asp:ListItem Value="1">Desayuno</asp:ListItem>
            <asp:ListItem Value="2">Almuerzo</asp:ListItem>
            <asp:ListItem Value="3">Cena</asp:ListItem>
        </asp:DropDownList>
        <br />
        Menu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Insertar" />
        <br />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel1" runat="server">
        RESTAURANTE<br /> Nombre
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Insertar" />
    </asp:Panel>
</asp:Content>

