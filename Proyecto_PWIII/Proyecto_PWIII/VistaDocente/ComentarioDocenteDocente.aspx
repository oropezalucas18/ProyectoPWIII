<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ComentarioDocenteDocente.aspx.cs" Inherits="Proyecto_PWIII.ComentarioDocenteDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 74px;
        }

        .auto-style3 {
            width: 590px;
        }

        .auto-style4 {
            width: 44%;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <table width="100%">
        <tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">
            <td style="vertical-align: top" class="auto-style4">
                <fieldset class="auto-style3">
                    <asp:TextBox ID="txbComment" runat="server" Width="585px" Visible="false"></asp:TextBox>
                    <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                    </table>
                </fieldset>
            </td>
            <td style="width: 70%; height: 100%; vertical-align: top">
                <fieldset>
                    <asp:Button ID="btnUpdate" runat="server" Text="Confirmar edicion" Width="353px" Style="text-align: center"  Height="25px" CssClass="auto-style2" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" Width="353px" Style="text-align: center"  BackColor="#FF3300" OnClick="btnDelete_Click"  />
                </fieldset>
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdShow" runat="server" Width="1753px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>

    
</asp:Content>
