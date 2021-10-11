<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ComentarioRequisitoDocente.aspx.cs" Inherits="Proyecto_PWIII.ComentarioRequisitoDocente" %>

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
<<<<<<< HEAD
    <asp:GridView ID="grdShowSubject" runat="server" Width="1753px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
=======
    <asp:GridView ID="grdShowSubject" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" runat="server" Width="1755px" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="1">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Pre-Requisito" SortExpression="comentario">
                <HeaderStyle CssClass="name"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="comentario" HeaderText="Requisito" SortExpression="nombre">
                <HeaderStyle CssClass="comentario"></HeaderStyle>
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Center" />
>>>>>>> main
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
<<<<<<< HEAD

    <footerstyle backcolor="#CCCCCC" />
    <headerstyle backcolor="Black" font-bold="True" forecolor="White" />
    <pagerstyle backcolor="#CCCCCC" forecolor="Black" horizontalalign="Center" />
    <rowstyle backcolor="White" />
    <selectedrowstyle backcolor="#000099" font-bold="True" forecolor="White" />
    <sortedascendingcellstyle backcolor="#F1F1F1" />
    <sortedascendingheaderstyle backcolor="#808080" />
    <sorteddescendingcellstyle backcolor="#CAC9C9" />
    <sorteddescendingheaderstyle backcolor="#383838" />
    </asp:GridView>
   
=======
>>>>>>> main
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
<<<<<<< HEAD
                    <asp:Button ID="btnUpdate" runat="server" Text="Confirmar edicion" Width="353px" Style="text-align: center" Height="25px" CssClass="auto-style2" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" Width="353px" Style="text-align: center" BackColor="#FF3300" OnClick="btnDelete_Click" />
=======
                    <asp:Button ID="btnUpdate" runat="server" Text="Confirmar edicion" Width="353px" Style="text-align: center" Visible="False" Height="25px" CssClass="auto-style2" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" Width="353px" Style="text-align: center" Visible="False" BackColor="#FF3300" />
>>>>>>> main
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
