<%@ Page Title=""  MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.AgregarPersona" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Agregar Persona</h1>
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Número de Documento:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="NroDoc" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="NroDoc" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Tipo de Documento:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TipoDoc" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="TipoDoc" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Apellido" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Apellido" runat="server" MaxLength="50"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="Nombre" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Nombre" runat="server" MaxLength="50"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Provincia:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="Provincia" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Provincia" runat="server" MaxLength="30"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="Localidad:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="Localidad" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Localidad" runat="server" MaxLength="30"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Dirección:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="Direccion" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Direccion" runat="server" MaxLength="50"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Text="Teléfono:"></asp:Label>
                <br />
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="Telefono" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Celular:"></asp:Label>
                <br />
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="Celular" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Celular" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Text="Email:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="Email" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Email" runat="server" MaxLength="50"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="Sexo:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="Sexo" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Sexo" runat="server" MaxLength="1"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="Estado Civil:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="EstadoCivil" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <br />
                <asp:DropDownList ID="EstadoCivil" runat="server">
                    <asp:ListItem Value="Soltero">Soltero</asp:ListItem>
                    <asp:ListItem>Casado</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label13" runat="server" Text="Nacionalidad:"></asp:Label>
                <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ControlToValidate="Nacionalidad" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="Nacionalidad" runat="server" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnAgregarPersona" runat="server" OnClick="btnAgregarPersona_Click" Text="Agregar" />
            </td>
        </tr>
    </table>
</asp:Content>

