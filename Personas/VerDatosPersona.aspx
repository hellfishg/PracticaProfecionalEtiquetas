<%@ Page Title="" Language="C#" MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="VerDatosPersona.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.VerDatosPersona" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Ver Datos Personas</h1>
    <p>
        <div runat="server" style="overflow-x:auto;width:556px; height:auto">
        <asp:GridView ID="grdVerPersonas" runat="server">
        </asp:GridView>
        </div>
    </p>
</asp:Content>

