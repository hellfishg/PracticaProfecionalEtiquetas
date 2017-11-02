<%@ Page Title="" Language="C#" MasterPageFile="~/Docentes/MPDocentes.master" AutoEventWireup="true" CodeBehind="VerDatosDocente.aspx.cs" Inherits="Sistema_de_etiquetas.Docentes.VerDatosDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <h2>Ver Datos Docente</h2>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="grdVerDocentes" runat="server" Font-Names="calibri" Width="100%">
                        <EditRowStyle />
              <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />


        </asp:GridView>

    </p>

</asp:Content>
