<%@ Page Title="" Language="C#" MasterPageFile="~/Docentes/MPDocentes.master" AutoEventWireup="true" CodeBehind="AgregarDocente.aspx.cs" Inherits="Sistema_de_etiquetas.Docentes.AgregarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h1>Agregar Docente</h1>
    <table style="width: 100%">
        <tr>
            <td style="width: 329px">
                <asp:Label ID="Label1" runat="server" Text="ID Docente:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Legajo:" style="color: #FFFFFF"></asp:Label>
                <asp:CompareValidator ID="cvLegajo" runat="server" ControlToValidate="Legajo" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ForeColor="#FF3333">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="Legajo" ErrorMessage="Ingrese legajo" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 329px">
                <asp:TextBox ID="IdDocente" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Legajo" runat="server" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 329px">
                <asp:Label ID="Label3" runat="server" Text="Tipo de Documento:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Numero de Documento:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rvNroDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numero de documento" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 329px">
                <asp:DropDownList ID="TipoDoc" runat="server" AutoPostBack="True" Font-Size="X-Large" Width="300px" OnSelectedIndexChanged="TipoDoc_SelectedIndexChanged">
                    <asp:ListItem Selected="True">DNI</asp:ListItem>
                    <asp:ListItem>Carnet de extranjero</asp:ListItem>
                    <asp:ListItem>Otros</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="NroDoc" runat="server" Font-Size="X-Large" Width="300px" OnSelectedIndexChanged="NroDoc_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 329px">
                <asp:ValidationSummary ID="vsSumario" runat="server" HeaderText="Errores encontrados:" ShowMessageBox="True" ShowSummary="False" ForeColor="#FF3333" style="margin-bottom: 0" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 329px">
                <asp:Button ID="AgregarDoc" runat="server" Text="Agregar" OnClick="AgregarDoc_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 329px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 329px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 329px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>

</asp:Content>

