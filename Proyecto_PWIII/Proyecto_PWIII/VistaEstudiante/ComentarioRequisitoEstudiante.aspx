<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ComentarioRequisitoEstudiante.aspx.cs" Inherits="Proyecto_PWIII.ComentarioRequisitoEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 327px;
        }

        .auto-style3 {
            width: 590px;
        }

        .auto-style4 {
            width: 44%;
        }

        .auto-style5 {
            width: 1283px;
        }

        .auto-style6 {
            margin-left: 540px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="auto-style5">
        <asp:GridView ID="grdListSubject" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" runat="server" Width="1753px" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="1">
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
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <table width="100%">
            <tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">
                <td style="vertical-align: top" class="auto-style4">
                    <fieldset class="auto-style3">
                        <asp:TextBox ID="txbComment" runat="server" Width="585px" ></asp:TextBox>
                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                        </table>
                    </fieldset>
                </td>
                <td style="width: 70%; height: 100%; vertical-align: top">
                    <fieldset>
                        <asp:Button ID="btnInsert" runat="server" Text="Comentar" Width="609px" Style="text-align: center" CssClass="auto-style6" OnClick="btnInsert_Click" />
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
    </div>
</asp:Content>
