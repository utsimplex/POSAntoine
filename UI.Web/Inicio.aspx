<%@ Page Title="" Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style24
        {
            font-size: x-large;
            font-weight: bold;
            text-align: center;
        }
        .style25
        {
            height: 34px;
        }
        .style26
        {
            height: 39px;
        }
        .style28
        {
            width: 21px;
        }
        .style30
        {
            width: 14px;
        }
        .style31
        {
            width: 576px;
            text-align: right;
        }
        .style32
        {
        text-align: center;
    }
        .style33
        {
            width: 606px;
        }
        .style34
        {
            width: 21px;
            height: 22px;
        }
        .style35
        {
            height: 22px;
        }
        .style36
        {
            text-align: center;
            height: 22px;
        }
        .style37
        {
            width: 576px;
            height: 22px;
        }
        .style38
        {
            width: 14px;
            height: 22px;
        }
        .style39
        {
            text-align: center;
            height: 31px;
        }
    .style40
    {
        width: 80px;
        height: 22px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style9">
        <tr>
            <td class="style25">
                </td>
        </tr>
        <tr>
            <td class="style24">
                Presupuesto para la compra de articulos</td>
        </tr>
        <tr>
            <td class="style26">
                <table class="style9">
                    <tr>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style35" colspan="2">
                            &nbsp;</td>
                        <td class="style36">
                            &nbsp;</td>
                        <td class="style37" colspan="2">
                            &nbsp;</td>
                        <td class="style38">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style34">
                        </td>
                        <td class="style35">
                        </td>
                        <td class="style40" colspan="3">
                        </td>
                        <td class="style37">
                        </td>
                        <td class="style38">
                        </td>
                    </tr>
                    <tr>
                        <td class="style28">
                            &nbsp;</td>
                        <td align="center" class="style33" rowspan="6" valign="top" colspan="2">
                <asp:GridView ID="gvArticulos" runat="server" AutoGenerateColumns="False" DataSourceID="odsArticulos" 
                    onselectedindexchanged="gvArticulos_SelectedIndexChanged" 
                    onselectedindexchanging="gvArticulos_SelectedIndexChanged" Width="447px" 
                                CellPadding="4" GridLines="Horizontal" BackColor="White" 
                                BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" 
                            SortExpression="Codigo" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                            SortExpression="Descripcion" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" 
                            SortExpression="Precio" />
                        <asp:CommandField SelectText="Insertar" ShowSelectButton="True" >
                            <ControlStyle ForeColor="Blue" />
                        </asp:CommandField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BorderColor="Black" />
                </asp:GridView>
                        </td>
                        <td class="style32">
                <asp:Label ID="lblInsertar" runat="server" Font-Bold="True" 
                    Text="Inserte cantidad del articulo" Visible="False" style="text-align: center"></asp:Label>
                        </td>
                        <td class="style31" rowspan="3" align="right" colspan="2">
                            <asp:GridView ID="gvPedido" runat="server" 
                                EmptyDataText="No hay articulos selecionados para el presupuesto" 
                                style="text-align: center; margin-left: 0px;" Width="505px" 
                                onselectedindexchanged="gvPedido_SelectedIndexChanged" 
                                onrowediting="gvPedido_Editar" 
                                CellPadding="4" GridLines="Horizontal" BackColor="White" 
                                BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                                <RowStyle BackColor="White" ForeColor="#333333" />
                                <Columns>
                                    <asp:CommandField SelectText="Quitar" ShowSelectButton="True" 
                                        ShowEditButton="True">
                                        <ControlStyle Font-Underline="True" ForeColor="Blue" />
                                    </asp:CommandField>
                                </Columns>
                                <FooterStyle BackColor="White" ForeColor="#333333" />
                                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BorderColor="Black" />
                            </asp:GridView>
                        </td>
                        <td class="style30">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style28" rowspan="5">
                            &nbsp;</td>
                        <td class="style32">
                <asp:Label ID="lbArticulo" runat="server" Text="Articulo"></asp:Label>
                <asp:TextBox ID="txtArticulo" runat="server" ReadOnly="True" Width="99px" 
                    Visible="False" TabIndex="1"></asp:TextBox>
                        </td>
                        <td class="style30" rowspan="5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style39">
                <asp:Label ID="lblCantidad" runat="server" Text="Cantidad" Visible="False"></asp:Label>
                            <asp:TextBox ID="txtCantidad" runat="server" Height="22px" Width="97px" 
                                Visible="False" TabIndex="1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style32">
                <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
                    Text="Aceptar" Visible="False" />
                        </td>
                        <td class="style31" rowspan="3" colspan="2">
                <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
&nbsp;
                <asp:TextBox ID="txtTotal" runat="server" Width="100px">0</asp:TextBox>
                            <br />
                            <br />
                            <asp:Button ID="btnLimpiar" runat="server" Height="24px" 
                                onclick="btnLimpiar_Click" style="text-align: center" 
                                Text="Limpiar presupuesto" Width="191px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style32">
                <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style32">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="odsArticulos" runat="server" SelectMethod="GetAll" 
                    TypeName="Data.Database.ArticuloAdapter"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

