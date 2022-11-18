<%@ Page Title="" Language="C#" MasterPageFile="~/vista/maestraLogin.master" AutoEventWireup="true" CodeFile="~/controlador/administrador.aspx.cs" Inherits="vista_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        usuarios</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODS_usuarios" DataKeyNames="Id_usuario" OnRowDataBound="GridView1_RowDataBound" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Id_usuario" HeaderText="Id_usuario" SortExpression="Id_usuario" />
                <asp:TemplateField HeaderText="Id_estado" SortExpression="Id_estado">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList11" runat="server" DataSourceID="ODS_estadosAdministrador" DataTextField="Nombre" DataValueField="Id_estado" SelectedValue='<%# Bind("Id_estado") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ODS_estadosAdministrador" DataTextField="Nombre" DataValueField="Id_estado" Enabled="False" SelectedValue='<%# Bind("Id_estado") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id_rol" SortExpression="Id_rol">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList12" runat="server" DataSourceID="ODS_rolAdministrador" DataTextField="Nombre" DataValueField="Id_rol" SelectedValue='<%# Bind("Id_rol") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="ODS_rolAdministrador" DataTextField="Nombre" DataValueField="Id_rol" Enabled="False" SelectedValue='<%# Bind("Id_rol") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Correo_electronico" HeaderText="Correo_electronico" SortExpression="Correo_electronico" />
                <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_usuarios" runat="server" SelectMethod="datos_usuarios" TypeName="Usuarios" DataObjectTypeName="USUARIO" DeleteMethod="eliminarUsuario" UpdateMethod="Ac_User"></asp:ObjectDataSource>
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
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_restaurante" runat="server" SelectMethod="datos_restauranteAdmin" TypeName="Usuarios" DataObjectTypeName="RESTAURANTE" DeleteMethod="eliminarRestaurante"></asp:ObjectDataSource>
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
                <asp:TemplateField HeaderText="id_Tipo" SortExpression="id_Tipo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_Tipo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="ODS_tipoMenuAdministrador" DataTextField="descripcion" DataValueField="id_tipo" Enabled="False" SelectedValue='<%# Bind("id_Tipo") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_menuAdministrador" runat="server" SelectMethod="datos_menuAdmin" TypeName="Usuarios" DataObjectTypeName="MENU" DeleteMethod="eliminarMenu"></asp:ObjectDataSource>
        <asp:Button ID="B_insertarM" runat="server" Text="Insertar" OnClick="B_insertarM_Click" />
    </p>
    <p>
        Pagos</p>
    <p>
        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_pagoAdministrador" OnRowDataBound="GridView6_RowDataBound" OnRowUpdating="GridView6_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Id_pago" HeaderText="Id_pago" SortExpression="Id_pago" />
                <asp:TemplateField HeaderText="Id_estudiante" SortExpression="Id_estudiante">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Id_estudiante") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList10" runat="server" DataSourceID="ODS_usuarios" DataTextField="Nombre" DataValueField="Id_usuario" Enabled="False" SelectedValue='<%# Bind("Id_estudiante") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fechas" SortExpression="Fechas">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Fechas") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Fechas") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Cantidad") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id_estado" SortExpression="Id_estado">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ODS_estadosAdministrador" DataTextField="Nombre" DataValueField="Id_estado" SelectedValue='<%# Bind("Id_estado") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ODS_estadosAdministrador" DataTextField="Nombre" DataValueField="Id_estado" Enabled="False" SelectedValue='<%# Bind("Id_estado") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Saldo" SortExpression="Saldo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Saldo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Saldo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Concepto" HeaderText="Concepto" SortExpression="Concepto" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_pagoAdministrador" runat="server" SelectMethod="datos_pagoAdmin" TypeName="Usuarios" DataObjectTypeName="PAGO" UpdateMethod="Ac_Pagos"></asp:ObjectDataSource>
    </p>
    <p>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Insertar" />
    </p>
    <p>
        Asistencia</p>
    <p>
        <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_asistenciaAdministrador">
            <Columns>
                <asp:BoundField DataField="id_asistencia" HeaderText="id_asistencia" SortExpression="id_asistencia" />
                <asp:TemplateField HeaderText="id_restaurante" SortExpression="id_restaurante">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_restaurante") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="ODS_restaurante" DataTextField="Nombre" DataValueField="Id_restaurante" Enabled="False" SelectedValue='<%# Bind("id_restaurante") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="id_usuario" SortExpression="id_usuario">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("id_usuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("id_usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                <asp:TemplateField HeaderText="id_tipo" SortExpression="id_tipo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("id_tipo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList9" runat="server" DataSourceID="ODS_tipoMenuAdministrador" DataTextField="descripcion" DataValueField="id_tipo" Enabled="False" SelectedValue='<%# Bind("id_tipo") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_asistenciaAdministrador" runat="server" SelectMethod="datos_Asistencia" TypeName="Usuarios"></asp:ObjectDataSource>
    </p>
    <p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insertar" />
    </p>
    <p>
        Tipo Menu</p>
    <p>
        <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_tipoMenuAdministrador">
            <Columns>
                <asp:BoundField DataField="id_tipo" HeaderText="id_tipo" SortExpression="id_tipo" />
                <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ODS_tipoMenuAdministrador" runat="server" SelectMethod="datos_tipoMenu" TypeName="Usuarios" DataObjectTypeName="TIPO" DeleteMethod="eliminarTipo"></asp:ObjectDataSource>
    </p>
    <p>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Insertar" />
    </p>
</asp:Content>

