<%@ Page Title="" Language="C#" MasterPageFile="~/Cursos/MPCursos.master" AutoEventWireup="true" CodeBehind="VerDatosCurso.aspx.cs" Inherits="Sistema_de_etiquetas.Cursos.VerDatosCurso" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Ver Datos Curso</h1>
    <p>
        <div runat="server" style="overflow-x:auto;width:556px; height:auto">
        <asp:GridView ID="grdVerCursos" runat="server" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Names="calibri" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            
        </asp:GridView>
        </div>
    </p>
</asp:Content>
