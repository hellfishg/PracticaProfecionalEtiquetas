<%@ Page Title="" Language="C#" MasterPageFile="~/Cursos/MPCursos.master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="Sistema_de_etiquetas.Cursos.AgregarCurso" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Curso</h1>

    <table style="width: 100%">
        <tr>
            <td style="width: 333px">
                <asp:Label ID="Label8" runat="server" Text="Codigo de Curso:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCodCurso" runat="server" ControlToValidate="CodCurso" ErrorMessage="Ingrese Codigo de Curso" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="A&ntilde;o:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvAnio" runat="server" ControlToValidate="Anio" ErrorMessage="Ingrese Anio" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvAnio" runat="server" ControlToValidate="Anio" ErrorMessage="Ingrese anio valido" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="2000" Font-Size="Large" ForeColor="#F81D22">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:TextBox ID="CodCurso" runat="server" MaxLength="4" Width="300px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Anio" runat="server" MaxLength="4" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:Label ID="Label1" runat="server" Text="Codigo de Carrera:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCodCarrera" runat="server" ControlToValidate="CodCarrera" ErrorMessage="Ingrese Codigo Carrera" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Cursada:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCursada" runat="server" ControlToValidate="Cursada" ErrorMessage="Ingrese Cursada" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:DropDownList ID="CodCarrera" runat="server" AutoPostBack="True" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
            <td>
                <asp:DropDownList ID="Cursada" runat="server" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:Label ID="Label2" runat="server" Text="Codigo de Materia:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCodMateria" runat="server" ControlToValidate="CodMateria" ErrorMessage="Ingrese Codigo Materia" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Turno:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvIdDocente" runat="server" ControlToValidate="IdDocente" ErrorMessage="Ingrese ID Docente" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:DropDownList ID="CodMateria" runat="server" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
            <td>
                <asp:DropDownList ID="ddlTurnos" runat="server" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:Label ID="Label7" runat="server" Text="ID Departamento:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvIdDepartamento" runat="server" ControlToValidate="IdDepartamento" ErrorMessage="Ingrese ID Departamento" Font-Size="Large" ForeColor="#F81D22">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="ID Docente:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:DropDownList ID="IdDepartamento" runat="server" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
            <td>
                <asp:DropDownList ID="IdDocente" runat="server" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td style="width: 333px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 333px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 333px">
                <asp:ValidationSummary ID="vsSumario" runat="server" HeaderText="Errores encontrados" ShowMessageBox="True" ShowSummary="False" ForeColor="#F81D22" />
            </td>
            <td>
                <asp:Button ID="AgregarCur" runat="server" Text="Agregar" OnClick="AgregarCur_Click" style="margin-left: 12px" Width="206px"/>
            </td>
        </tr>
        </table>
</asp:Content>




