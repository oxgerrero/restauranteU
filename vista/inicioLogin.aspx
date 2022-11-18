<%@ Page Title="" Language="C#" MasterPageFile="~/vista/maestraLogin.master" AutoEventWireup="true" CodeFile="~/controlador/inicioLogin.aspx.cs" Inherits="vista_inicioLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>Asistencias<br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ODS_asistenciaUsuario" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                Restaurante:<br />
                <asp:Label ID="nombreRestauranteLabel" runat="server" Text='<%# Eval("nombreRestaurante") %>' />
                <br />
                Fecha asistencia:
                <br />
                <asp:Label ID="fechaAsistenciaLabel" runat="server" Text='<%# Eval("fechaAsistencia") %>' />
                <br />
                Tipo asistencia:
                <br />
                <asp:Label ID="tipoAsistenciaLabel" runat="server" Text='<%# Eval("tipoAsistencia") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
        <asp:ObjectDataSource ID="ODS_asistenciaUsuario" runat="server" SelectMethod="datos_AsistenciaUser" TypeName="Usuarios">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id" SessionField="IDUSER" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        Pagos<br />
        <asp:DataList ID="DataList2" runat="server" DataSourceID="ODS_pagosUser" CellPadding="4" ForeColor="#333333" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                fecha:
                <br />
                <asp:Label ID="fechaLabel" runat="server" Text='<%# Eval("fecha") %>' />
                <br />
                pagado:
                <br />
                <asp:Label ID="pagadoLabel" runat="server" Text='<%# Eval("pagado") %>' />
                <br />
                saldo:
                <br />
                <asp:Label ID="saldoLabel" runat="server" Text='<%# Eval("saldo") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
        <asp:ObjectDataSource ID="ODS_pagosUser" runat="server" SelectMethod="datos_PagosUser" TypeName="Usuarios">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="0" Name="id" SessionField="IDUSER" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        Menu<br />
        <asp:DataList ID="DataList3" runat="server" CellPadding="4" DataSourceID="ODS_menuUser" ForeColor="#333333" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <ItemTemplate>
                fecha:
                <br />
                <asp:Label ID="fechaLabel" runat="server" Text='<%# Eval("fecha") %>' />
                <br />
                menu:
                <br />
                <asp:Label ID="menuLabel" runat="server" Text='<%# Eval("menu") %>' />
                <br />
                tipo:
                <br />
                <asp:Label ID="tipoLabel" runat="server" Text='<%# Eval("tipo") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <asp:ObjectDataSource ID="ODS_menuUser" runat="server" SelectMethod="datos_MenuUser" TypeName="Usuarios"></asp:ObjectDataSource>
    </div>
</asp:Content>

