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
                    <asp:TextBox ID="txbComentario" runat="server" Width="585px" Visible="false"></asp:TextBox>
                    <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                    </table>
                </fieldset>
            </td>
            <td style="width: 70%; height: 100%; vertical-align: top">
                <fieldset>
                    <asp:Button ID="btnEditar" runat="server" Text="Confirmar edicion" Width="353px" Style="text-align: center" visible="False" CssClass="auto-style2" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="353px" Style="text-align: center" visible="False" BackColor="#FF3300"  />
                </fieldset>
            </td>
        </tr>
    </table>
    <asp:GridView ID="grvListaSolicitudes" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" runat="server" Width="1381px" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="1">
        <columns>
            <asp:BoundField DataField="nombre" HeaderStyle-CssClass="name" HeaderText="Nombre Estudiante" SortExpression="name">
                <headerstyle cssclass="name"></headerstyle>
                <itemstyle cssclass="itName"></itemstyle>
            </asp:BoundField>
            <asp:BoundField DataField="comentario" HeaderStyle-CssClass="comentario" HeaderText="Comentario" SortExpression="college">
                <headerstyle cssclass="comentario"></headerstyle>
                <itemstyle cssclass="itCollege"></itemstyle>
            </asp:BoundField>
            <asp:ButtonField ButtonType="Button" HeaderStyle-CssClass="notify" HeaderText="Edicion" ControlStyle-CssClass="btnVer" Text="Editar">
                <controlstyle cssclass="btnVer"></controlstyle>
                <headerstyle cssclass="notify"></headerstyle>
            </asp:ButtonField>
        </columns>
        <footerstyle backcolor="#CCCCCC" />
        <headerstyle backcolor="Black" font-bold="True" forecolor="White" />
        <pagerstyle backcolor="#CCCCCC" forecolor="Black" horizontalalign="Left" />
        <rowstyle backcolor="White" />
        <selectedrowstyle backcolor="#000099" font-bold="True" forecolor="White" />
        <sortedascendingcellstyle backcolor="#F1F1F1" />
        <sortedascendingheaderstyle backcolor="#808080" />
        <sorteddescendingcellstyle backcolor="#CAC9C9" />
        <sorteddescendingheaderstyle backcolor="#383838" />
    </asp:GridView>

</asp:Content>
