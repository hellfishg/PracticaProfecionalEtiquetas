<%@ Page Title="" Language="C#" MasterPageFile="~/Docentes/MPDocentes.master" AutoEventWireup="true" CodeBehind="AgregarDocente.aspx.cs" Inherits="Sistema_de_etiquetas.Docentes.AgregarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h1>Agregar Docente</h1>
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="ID Docente:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="IdDocente" runat="server" style="color: #FFFFFF"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Número de Documento:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="NroDoc" runat="server" style="color: #FFFFFF"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Tipo de Documento:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="TipoDoc" runat="server" style="color: #FFFFFF"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Legajo:" style="color: #FFFFFF"></asp:Label>
                <asp:TextBox ID="Legajo" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #FFFFFF">&nbsp;</td>
            <td>
                <asp:Button ID="AgregarDoc" runat="server" Text="Agregar" OnClick="AgregarDoc_Click" PostBackUrl="~/Docentes/VerDatosDocente.aspx" />
            </td>
        </tr>
    </table>

</asp:Content>

