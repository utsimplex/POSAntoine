<%@ Page Title="" Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="Listado de artículos.aspx.cs" Inherits="Listado_de_artículos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style8
        {
            width: 621px;
        }
        .style8
        {
            width: 256px;
        }
        .style9
        {
            width: 444px;
        }
        .style10
        {
            width: 216px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <table class="style7">
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style10">
                <asp:Label ID="lblListado" runat="server" Font-Size="X-Large" 
                    Text="Listado de articulos" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p align="center">
        <asp:Label ID="lblFiltro" runat="server" Text="Filtrar"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFiltro" runat="server" AutoCompleteType="Disabled" 
            AutoPostBack="True" ontextchanged="txtFiltro_TextChanged" Width="534px" 
            TabIndex="9"></asp:TextBox>
</p>
<p>
    <asp:GridView ID="gvArticulos" runat="server" AllowPaging="True"  
        AutoGenerateColumns="False" 
        DataSourceID="odsArticulos" Height="16px" HorizontalAlign="Center" 
        Width="814px" TabIndex="10" 
        CellPadding="4" GridLines="Horizontal" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" 
                SortExpression="Codigo" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                SortExpression="Descripcion" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
            <asp:BoundField DataField="StockMin" HeaderText="StockMin" 
                SortExpression="StockMin" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" 
                SortExpression="Precio" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</p>
<p>
    <asp:ObjectDataSource ID="odsArticulos" runat="server" 
        onselecting="odsArticulos_Selecting" SelectMethod="GetAll" 
        TypeName="Data.Database.ArticuloAdapter"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsActualizar" runat="server" SelectMethod="Busqueda" 
        TypeName="Data.Database.ArticuloAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtFiltro" Name="texto" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
</asp:Content>

