<%@ Page Title="" Language="C#" MasterPageFile="~/Docentes/MPDocentes.master" AutoEventWireup="true" CodeBehind="VerDatosDocente.aspx.cs" Inherits="Sistema_de_etiquetas.Docentes.VerDatosDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2>Ver Datos Docente</h2>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="grdVerDocentes" runat="server">
        </asp:GridView>

    </p>

</asp:Content>
