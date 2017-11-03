<%@ Page Title="" Language="C#" MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.AgregarPersona" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Persona</h1>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Numero de Documento:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NroDoc" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="cvNroDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numeros validos" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="rfvNumDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numero de documento">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Tipo de Documento:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="TipoDoc" runat="server">
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
            <td>
                <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Apellido" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="Apellido" ErrorMessage="Ingrese apellido">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revApellido" runat="server" ControlToValidate="Apellido" ErrorMessage="Apellido solo letras" ValidationExpression="[A-Za-z ]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 23px"></td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Nombre" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="Nombre" ErrorMessage="Ingrese nombre">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ControlToValidate="Nombre" ErrorMessage="Solo letras Nombre" ValidationExpression="[A-Za-z ]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Provincia:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Provincia" runat="server" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="Provincia" ErrorMessage="Ingrese provincia">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revProvincia" runat="server" ControlToValidate="Provincia" ErrorMessage="Provincia solo letras" ValidationExpression="[A-Za-z ]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Localidad:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Localidad" runat="server" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="Localidad" ErrorMessage="Ingrese Localidad">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revLocalidad" runat="server" ControlToValidate="Localidad" ErrorMessage="Localidad solo letras" ValidationExpression="[A-Za-z ]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Direccion:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Direccion" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="Direccion" ErrorMessage="Ingrese Direccion">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 23px"></td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Telefono:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="Telefono" ErrorMessage="Ingrese telefono">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvTelefono" runat="server" ControlToValidate="Telefono" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Celular:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Celular" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCelular" runat="server" ControlToValidate="Celular" ErrorMessage="Ingrese celular">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvCelular" runat="server" ControlToValidate="Celular" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Email" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="Email" ErrorMessage="Ingrese email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="Email" ErrorMessage="Ingrese email valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 23px"></td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Sexo:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="Sexo" runat="server">
                    <asp:ListItem Selected="True" Value="F">Femenino</asp:ListItem>
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Estado Civil:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="EstadoCivil" runat="server">
                    <asp:ListItem Selected="True">Soltero</asp:ListItem>
                    <asp:ListItem>Casado</asp:ListItem>
                    <asp:ListItem>Divorciado</asp:ListItem>
                    <asp:ListItem>Viudo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Nacionalidad:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Nacionalidad" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="Nacionalidad" ErrorMessage="Ingrese nacionalidad">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNacionalidad" runat="server" ControlToValidate="Nacionalidad" ErrorMessage="Nacionalidad solo letras" ValidationExpression="[A-Za-z ]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ValidationSummary ID="vsSumario" runat="server" HeaderText="Errores encontrados:" Height="17px" ShowMessageBox="True" ShowSummary="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="AgregarPRSNA" runat="server" Text="Agregar" OnClick="AgregarPRSNA_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

