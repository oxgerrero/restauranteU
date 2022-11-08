<%@ Page Title="" Language="C#" MasterPageFile="~/vista/maestraLogin.master" AutoEventWireup="true" CodeFile="~/controlador/administrador.aspx.cs" Inherits="vista_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        usuarios</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODS_usuarios">
            <Columns>
                <asp:BoundField DataField="Id_usuario" HeaderText="Id_usuario" SortExpression="Id_usuario" />
                <asp:BoundField DataField="Id_estado" HeaderText="Id_estado" SortExpression="Id_estado" />
                <asp:BoundField DataField="Id_rol" HeaderText="Id_rol" SortExpression="Id_rol" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Correo_electronico" HeaderText="Correo_electronico" SortExpression="Correo_electronico" />
                <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_usuarios" runat="server" SelectMethod="datos_usuarios" TypeName="Usuarios"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarU" runat="server" OnClick="B_insertarU_Click" Text="Insertar" />
    </p>
    <p>
        Estados</p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_estadosAdministrador">
            <Columns>
                <asp:BoundField DataField="Id_estado" HeaderText="Id_estado" SortExpression="Id_estado" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_estadosAdministrador" runat="server" SelectMethod="datos_estadosAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarE" runat="server" OnClick="B_insertarE_Click" Text="Insertar" />
    </p>
    <p>
        Rol</p>
    <p>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_rolAdministrador">
            <Columns>
                <asp:BoundField DataField="Id_rol" HeaderText="Id_rol" SortExpression="Id_rol" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_rolAdministrador" runat="server" SelectMethod="datos_rolAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarR" runat="server" Text="Insertar" OnClick="B_insertarR_Click" />
    </p>
    <p>
        Restaurantes</p>
    <p>
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_restaurante">
            <Columns>
                <asp:BoundField DataField="Id_restaurante" HeaderText="Id_restaurante" SortExpression="Id_restaurante" />
                <asp:BoundField DataField="Id_menu" HeaderText="Id_menu" SortExpression="Id_menu" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Id_usuario" HeaderText="Id_usuario" SortExpression="Id_usuario" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_restaurante" runat="server" SelectMethod="datos_restauranteAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarRes" runat="server" Text="Insertar" OnClick="B_insertarRes_Click" />
    </p>
    <p>
        Menu</p>
    <p>
        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_menuAdministrador">
            <Columns>
                <asp:BoundField DataField="Id_menu" HeaderText="Id_menu" SortExpression="Id_menu" />
                <asp:BoundField DataField="Dia" HeaderText="Dia" SortExpression="Dia" />
                <asp:BoundField DataField="Menu" HeaderText="Menu" SortExpression="Menu" />
                <asp:BoundField DataField="Tipo_menu" HeaderText="Tipo_menu" SortExpression="Tipo_menu" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_menuAdministrador" runat="server" SelectMethod="datos_menuAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarM" runat="server" Text="Insertar" OnClick="B_insertarM_Click" />
    </p>
    <p>
        Pagos</p>
    <p>
        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_pagoAdministrador">
            <Columns>
                <asp:BoundField DataField="Id_pago" HeaderText="Id_pago" SortExpression="Id_pago" />
                <asp:BoundField DataField="Id_estudiante" HeaderText="Id_estudiante" SortExpression="Id_estudiante" />
                <asp:BoundField DataField="Fechas" HeaderText="Fechas" SortExpression="Fechas" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                <asp:BoundField DataField="Id_estado" HeaderText="Id_estado" SortExpression="Id_estado" />
                <asp:BoundField DataField="Saldo" HeaderText="Saldo" SortExpression="Saldo" />
                <asp:BoundField DataField="Concepto" HeaderText="Concepto" SortExpression="Concepto" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_pagoAdministrador" runat="server" SelectMethod="datos_pagoAdmin" TypeName="Usuarios"></asp:ObjectDataSource>
    </p>
</asp:Content>

