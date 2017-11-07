<%@ Page Title="" Language="C#" MasterPageFile="~/Materias/MPMaterias.master" AutoEventWireup="true" CodeBehind="AgregarMateria.aspx.cs" Inherits="Sistema_de_etiquetas.Materias.AgregarMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h1>Agregar Materia</h1>

    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nombre de Materia:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="#F81D22"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtNombre" runat="server" style="color: #000000" Width="300px"></asp:TextBox>
                </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Cursada:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlCursadas" ErrorMessage="*" ForeColor="#FF4040"></asp:RequiredFieldValidator>
                <br />
                <asp:DropDownList ID="ddlCursadas" runat="server" style="color: #000000" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:Label ID="Label2" runat="server" Text="Código de Materia:" style="color: #FFFFFF"></asp:Label>
                </td>
            <td style="width: 411px">
                <asp:Label ID="Label6" runat="server" Text="Código de Carrera:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlcarreras" ErrorMessage="*" ForeColor="#FF4040"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:TextBox ID="txtCodigo" runat="server" style="color: #000000" Width="300px"></asp:TextBox>
                </td>
            <td style="width: 411px">
                <asp:DropDownList ID="ddlcarreras" runat="server" style="color: #000000" Font-Size="X-Large" Width="300px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:Label ID="Label4" runat="server" Text="Tipo de Plan:" style="color: #FFFFFF"></asp:Label>
                </td>
            <td style="width: 411px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:TextBox ID="txtTipoPlan" runat="server" style="color: #000000" Width="300px"></asp:TextBox>
                </td>
            <td style="width: 411px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 411px">
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
                </td>
            <td style="width: 411px">
                &nbsp;</td>
        </tr>
        </table>

</asp:Content>