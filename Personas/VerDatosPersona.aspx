<%@ Page Title="" Language="C#" MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="VerDatosPersona.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.VerDatosPersona" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="contenidoPrincipal">
    <h1>Ver Datos Personas</h1>
        <div runat="server" style="overflow-x:auto;width:100%; height:auto">
        <asp:GridView ID="grdVerPersonas" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Names="calibri" ForeColor="Black" GridLines="Horizontal" Width="100%" Font-Size="Small">
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
</asp:Content>

