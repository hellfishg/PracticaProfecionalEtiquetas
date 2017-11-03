<%@ Page Title="" Language="C#" MasterPageFile="~/Departamentos/MPDepartamentos.master" AutoEventWireup="true" CodeBehind="AgregarDepartamento.aspx.cs" Inherits="Sistema_de_etiquetas.Departamentos.AgregarDepartamento" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Departamentos</h1>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Código de Departamento:" style="color: #FFFFFF"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" style="color: #000000" Width="264px"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Descripción:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
            </td>
        </tr>
        </table>
</asp:Content>

