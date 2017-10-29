<%@ Page Title="" Language="C#" MasterPageFile="~/Cursos/MPCursos.master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="Sistema_de_etiquetas.Cursos.AgregarCurso" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Curso</h1>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Código de Carrera:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CodCarrera" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Código de Materia:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CodMateria" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Año:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Anio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Cursada:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Cursada" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Turno:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTurnos" runat="server">
                </asp:DropDownList>
&nbsp;Enlazar con tabla Turnos</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="ID Docente:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdDocente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="ID Departamento:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdDepartamento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Código de Curso:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CodCurso" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="AgregarCur" runat="server" Text="Agregar" OnClick="AgregarCur_Click" PostBackUrl="~/Cursos/VerDatosCurso.aspx"/>
            </td>
        </tr>
    </table>
</asp:Content>




