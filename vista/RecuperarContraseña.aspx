<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MaestraSinLogin.master" AutoEventWireup="true" CodeFile="~/controlador/RecuperarContraseña.aspx.cs" Inherits="vista_RecuperarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">user<asp:TextBox ID="TB_user" onkeypress="this.value=sololetras(this.value,2,30)" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="B_recuperar" runat="server" OnClick="B_recuperar_Click" Text="Recuperar" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
            </table>
</asp:Content>

