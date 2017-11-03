<%@ Page Title="" Language="C#" MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.AgregarPersona" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Persona</h1>
    <table style="width: 100%">
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label2" runat="server" Text="Tipo de Documento:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label1" runat="server" Text="Numero de Documento:" style="color: #FFFFFF"></asp:Label>
                <asp:CompareValidator ID="cvNroDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numeros validos" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ForeColor="#FF3333">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="rfvNumDoc" runat="server" ControlToValidate="NroDoc" ErrorMessage="Ingrese numero de documento" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:DropDownList ID="TipoDoc" runat="server" Font-Size="X-Large" Width="300px">
                    <asp:ListItem Selected="True">DNI</asp:ListItem>
                    <asp:ListItem>Carnet de extranjero</asp:ListItem>
                    <asp:ListItem>Otros</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="color: #FF3E3E">
                <asp:TextBox ID="NroDoc" runat="server" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label4" runat="server" Text="Nombre:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="Nombre" ErrorMessage="Ingrese nombre" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ControlToValidate="Nombre" ErrorMessage="Solo letras Nombre" ValidationExpression="[A-Za-z ]*" ForeColor="#FF3333">*</asp:RegularExpressionValidator>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label3" runat="server" Text="Apellido:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="Apellido" ErrorMessage="Ingrese apellido" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revApellido" runat="server" ControlToValidate="Apellido" ErrorMessage="Apellido solo letras" ValidationExpression="[A-Za-z ]*" ForeColor="#FF3333">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:TextBox ID="Nombre" runat="server" MaxLength="50" Width="300px"></asp:TextBox>
                </td>
            <td style="color: #FF3E3E">
                <asp:TextBox ID="Apellido" runat="server" MaxLength="50" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label5" runat="server" Text="Provincia:" style="color: #FFFFFF"></asp:Label>
                <asp:RegularExpressionValidator ID="revProvincia" runat="server" ControlToValidate="Provincia" ErrorMessage="Provincia solo letras" ValidationExpression="[A-Za-z ]*" ForeColor="#FF3333">*</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="Provincia" ErrorMessage="Ingrese provincia" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label6" runat="server" Text="Localidad:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="Localidad" ErrorMessage="Ingrese Localidad" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revLocalidad" runat="server" ControlToValidate="Localidad" ErrorMessage="Localidad solo letras" ValidationExpression="[A-Za-z ]*" ForeColor="#FF3333">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 363px;">
                <asp:TextBox ID="Provincia" runat="server" MaxLength="30" Width="300px"></asp:TextBox>
                </td>
            <td style="height: 23px">
                <asp:TextBox ID="Localidad" runat="server" MaxLength="30" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label8" runat="server" Text="Telefono:" style="color: #FFFFFF"></asp:Label>
                <asp:CompareValidator ID="cvTelefono" runat="server" ControlToValidate="Telefono" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ForeColor="#FF3333">*</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="Telefono" ErrorMessage="Ingrese telefono" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label9" runat="server" Text="Celular:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCelular" runat="server" ControlToValidate="Celular" ErrorMessage="Ingrese celular" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvCelular" runat="server" ControlToValidate="Celular" ErrorMessage="Ingrese numeros" Operator="GreaterThan" Type="Integer" ValueToCompare="0" ForeColor="#FF3333">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:TextBox ID="Telefono" runat="server" Width="300px"></asp:TextBox>
                </td>
            <td style="color: #FF3E3E">
                <asp:TextBox ID="Celular" runat="server" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label7" runat="server" Text="Direccion:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="Direccion" ErrorMessage="Ingrese Direccion" style="color: #FF3E3E">*</asp:RequiredFieldValidator>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label10" runat="server" Text="Email:" style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="Email" ErrorMessage="Ingrese email" ForeColor="#FF3333">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="Email" ErrorMessage="Ingrese email valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF3333">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:TextBox ID="Direccion" runat="server" MaxLength="50" OnTextChanged="Direccion_TextChanged" Width="300px"></asp:TextBox>
                </td>
            <td style="color: #FF3E3E">
                <asp:TextBox ID="Email" runat="server" MaxLength="50" Width="300px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label11" runat="server" Text="Sexo:" style="color: #FFFFFF"></asp:Label>
            </td>
            <td style="color: #FF3E3E">
                <asp:Label ID="Label12" runat="server" Text="Estado Civil:" style="color: #FFFFFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:DropDownList ID="Sexo" runat="server" Font-Size="X-Large" Width="300px">
                    <asp:ListItem Selected="True" Value="F">Femenino</asp:ListItem>
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="color: #FF3E3E">
                <asp:DropDownList ID="EstadoCivil" runat="server" Font-Size="X-Large" Width="300px">
                    <asp:ListItem Selected="True">Soltero</asp:ListItem>
                    <asp:ListItem>Casado</asp:ListItem>
                    <asp:ListItem>Divorciado</asp:ListItem>
                    <asp:ListItem>Viudo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Label ID="Label13" runat="server" Text="Nacionalidad:" style="color: #FFFFFF"></asp:Label>
                <asp:RegularExpressionValidator ID="revNacionalidad" runat="server" ControlToValidate="Nacionalidad" ErrorMessage="Nacionalidad solo letras" ValidationExpression="[A-Za-z ]*" ForeColor="#EC2B30">*</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="Nacionalidad" ErrorMessage="Ingrese nacionalidad" ForeColor="#EC2B30">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 23px; width: 363px;">
                <asp:TextBox ID="Nacionalidad" runat="server" MaxLength="50" Width="300px"></asp:TextBox>
                </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:ValidationSummary ID="vsSumario" runat="server" HeaderText="Errores encontrados:" Height="17px" ShowMessageBox="True" ShowSummary="False" ForeColor="#EC2B30" />
            </td>
            <td style="color: #FF3E3E">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 363px">&nbsp;</td>
            <td style="color: #FF3E3E">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 363px">
                <asp:Button ID="AgregarPRSNA" runat="server" Text="Agregar" OnClick="AgregarPRSNA_Click" />
            </td>
            <td style="color: #FF3E3E">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

