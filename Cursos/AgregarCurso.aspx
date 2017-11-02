<%@ Page Title="" Language="C#" MasterPageFile="~/Cursos/MPCursos.master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="Sistema_de_etiquetas.Cursos.AgregarCurso" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Curso</h1>
    <p>&nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Código de Carrera:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="CodCarrera" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Código de Materia:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="CodMateria" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Año:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="Anio" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Cursada:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="Cursada" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 17px">
                <asp:Label ID="Label5" runat="server" Text="Turno:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlTurnos" runat="server" DataSourceID="SqlDataSource1" DataTextField="Turno" DataValueField="CodHorario" style="color: #FFFFFF">
                </asp:DropDownList>
                <span style="color: #FFFFFF">&nbsp;Enlazar con tabla Turnos</span></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="ID Docente:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="IdDocente" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="ID Departamento:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="IdDepartamento" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Código de Curso:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="CodCurso" runat="server" style="color: #FFFFFF"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #FFFFFF">
                <asp:Button ID="AgregarCur" runat="server" Text="Agregar" OnClick="AgregarCur_Click" PostBackUrl="~/Cursos/VerDatosCurso.aspx"/>
            </td>
        </tr>
    </table>
</asp:Content>




