<%@ Page Title="" Language="C#" MasterPageFile="~/Etiquetas/MPEtiquetas.master" AutoEventWireup="true" CodeBehind="BusquedaEtiqueta.aspx.cs" Inherits="Sistema_de_etiquetas.Etiquetas.BusquedaEtiqueta" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Etiquetas</h1>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Carrera:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCarrera" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Materia:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMateria" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Turno:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTurno" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="color: #FFFFFF">Enlazar Todos los DropDownList con la Tabla Cursos</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Docente:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDocente" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Año:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAño" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Aceptar" />
            </td>
        </tr>
    </table>
</asp:Content>

