<%@ Page Title="" Language="C#" MasterPageFile="~/Carreras/MPCarreras.master" AutoEventWireup="true" CodeBehind="AgregarCarrera.aspx.cs" Inherits="Sistema_de_etiquetas.Carreras.AgregarCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h1>Agregar Carrera</h1>
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Código de la Carrera:" Style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxCod" runat="server" ErrorMessage="*" ForeColor="#FF4242"></asp:RequiredFieldValidator>

                <br />
                <asp:TextBox ID="TextBoxCod" runat="server" Width="300px"></asp:TextBox>
                <p class="auto-style3">
                    El codigo debe tener menos de 4 caracteres y mas de 1.</p>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nombre de la Carrera:" Style="color: #FFFFFF"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="*" ForeColor="#FF4242"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 141px; text-align: right;">
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
