<%@ Page Title="" Language="C#" MasterPageFile="~/Materias/MPMaterias.master" AutoEventWireup="true" CodeBehind="AgregarMateria.aspx.cs" Inherits="Sistema_de_etiquetas.Materias.AgregarMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2>Agregar Materia</h2>
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Código de Carrera:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="color: #000000"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Código de Materia:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="color: #000000"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Nombre de Materia:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" style="color: #000000"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Tipo de Plan:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="color: #000000"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Cursada:" style="color: #FFFFFF"></asp:Label>
                <span style="color: #FFFFFF">&nbsp;</span></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlCursadas" runat="server" style="color: #000000">
                </asp:DropDownList>
                <span style="color: #FFFFFF">Conectar con Tabla Cursadas<br />
                </span></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>