<%@ Page Title="" Language="C#" MasterPageFile="~/Cursos/MPCursos.master" AutoEventWireup="true" CodeBehind="VerDatosCurso.aspx.cs" Inherits="Sistema_de_etiquetas.Cursos.VerDatosCurso" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Ver Datos Curso</h1>
    <p>
        <div runat="server" style="overflow-x:auto;width:556px; height:auto">
        <asp:GridView ID="grdVerCursos" runat="server" Width="100">
            
        </asp:GridView>
        </div>
    </p>
</asp:Content>
