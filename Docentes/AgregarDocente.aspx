<%@ Page Title="" Language="C#" MasterPageFile="~/Docentes/MPDocentes.master" AutoEventWireup="true" CodeBehind="AgregarDocente.aspx.cs" Inherits="Sistema_de_etiquetas.Docentes.AgregarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2>Agregar Docente</h2>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="ID Docente:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdDocente" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Numero de Documento:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="NroDoc" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rvNroDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numero de documento">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Tipo de Documento:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="TipoDoc" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">DNI</asp:ListItem>
                    <asp:ListItem>Carnet de extranjero</asp:ListItem>
                    <asp:ListItem>Otros</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 30px">
                <asp:Label ID="Label4" runat="server" Text="Legajo:"></asp:Label>
            </td>
            <td style="height: 30px">
                <asp:TextBox ID="Legajo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="Legajo" ErrorMessage="Ingrese legajo">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvLegajo" runat="server" ControlToValidate="Legajo" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ValidationSummary ID="vsSumario" runat="server" HeaderText="Errores encontrados:" ShowMessageBox="True" ShowSummary="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="AgregarDoc" runat="server" Text="Agregar" OnClick="AgregarDoc_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

