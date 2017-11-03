<%@ Page Title="" Language="C#" MasterPageFile="~/Carreras/MPCarreras.master" AutoEventWireup="true" CodeBehind="AgregarCarrera.aspx.cs" Inherits="Sistema_de_etiquetas.Carreras.AgregarCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h1>Agregar Carrera</h1>
    <p>
        <table style="width: 100%">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Código de la Carrera:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxCod" runat="server" Width="300px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Nombre de la Carrera:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 141px; text-align: right;">
                    <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
&nbsp;</p>
    <p>&nbsp;</p>

</asp:Content>