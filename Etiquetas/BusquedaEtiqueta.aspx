<%@ Page Title="" Language="C#" MasterPageFile="~/Etiquetas/MPEtiquetas.master" AutoEventWireup="true" CodeBehind="BusquedaEtiqueta.aspx.cs" Inherits="Sistema_de_etiquetas.Etiquetas.BusquedaEtiqueta" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="contenidoPrincipal">

     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


     <br />
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
           
 


    <h1>Etiquetas</h1>
    <table style="width: 100%">
       
        <tr>
            <td style="width: 80px">
                <asp:Label ID="Label1" runat="server" Text="Carrera:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCarrera" runat="server" OnSelectedIndexChanged="ddlCarrera_SelectedIndexChanged" AutoPostBack="True" Style="margin-left: 0px" AppendDataBoundItems="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 80px;"></td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 80px">
                <asp:Label ID="Label2" runat="server" Text="Materia:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMaterias" runat="server" OnSelectedIndexChanged="ddlMaterias_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 80px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 80px">
                <asp:Label ID="Label3" runat="server" Text="Turno:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTurnos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTurnos_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 80px">
                <asp:Label ID="Label4" runat="server" Text="Docente:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDocentes" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDocentes_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 80px">
                <asp:Label ID="Label5" runat="server" Text="Año:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAnio" runat="server" AutoPostBack="True" AppendDataBoundItems="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 80px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Imprimir" />
            </td>
        </tr>
    </table>
                     </ContentTemplate>
     </asp:UpdatePanel>
</asp:Content>

