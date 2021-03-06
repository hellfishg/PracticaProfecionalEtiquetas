<%@ Page Title="" Language="C#" MasterPageFile="~/Personas/MPPersonas.master" AutoEventWireup="true" CodeBehind="AdministrarPersonas.aspx.cs" Inherits="Sistema_de_etiquetas.Personas.AdministrarPersonas" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="contenidoPrincipal">


    <div runat="server" style="overflow-x: auto; width: 100%; height: auto">
        <div>
            <h1 class="titulo">Administrar Personas</h1>
            <p class="titulo">&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="319px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" Width="103px" />
            </p>
            <p class="titulo">&nbsp;</p>
        </div>
        <div class="grid">
            <asp:GridView ID="grdAdministrarPersonas" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowEditing="grdAdministrarPersonas_RowEditing" OnRowCancelingEdit="grdAdministrarPersonas_RowCancelingEdit" OnRowUpdating="grdAdministrarPersonas_RowUpdating" OnRowDeleting="grdAdministrarPersonas_RowDeleting" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Names="Calibri" ForeColor="Black" GridLines="Horizontal" Width="100%" OnSelectedIndexChanged="grdAdministrarPersonas_SelectedIndexChanged" Font-Size="X-Small">
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

    </div>
</asp:Content>
