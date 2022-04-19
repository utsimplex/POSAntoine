<%@ Page Title="" Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="Clientes.aspx.cs" Inherits="Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
        }
        .style13
        {
            width: 419px;
        }
        .style17
        {
            width: 94px;
            height: 31px;
        }
        .style18
        {
            height: 31px;
            width: 396px;
        }
        .style19
        {
            width: 137px;
            height: 31px;
        }
        .style21
        {
            height: 32px;
            width: 396px;
        }
        .style26
        {
            width: 419px;
            height: 32px;
        }
        .style27
        {
            width: 94px;
            height: 33px;
        }
        .style28
        {
            height: 33px;
            width: 396px;
        }
        .style29
        {
            width: 137px;
            height: 33px;
        }
        .style30
        {
            width: 419px;
            height: 34px;
        }
        .style32
        {
            height: 34px;
            width: 396px;
        }
        .style34
        {
            width: 86px;
        }
        .style35
        {
            width: 86px;
            height: 32px;
        }
        .style36
        {
            width: 86px;
            height: 34px;
        }
        .style37
        {
            width: 137px;
        }
        .style38
        {
            width: 137px;
            height: 32px;
        }
        .style39
        {
            width: 137px;
            height: 34px;
        }
        .style40
        {
            width: 69px;
        }
        .style41
        {
            width: 69px;
            height: 32px;
        }
        .style42
        {
            width: 69px;
            height: 34px;
        }
        .style43
        {
            width: 408px;
        }
        .style44
        {
            width: 396px;
        }
        .style45
        {
        }
        .style48
        {
            width: 764px;
        }
        .style50
        {
            width: 909px;
        }
        .style51
        {
            width: 824px;
        }
        .style52
        {
            width: 94px;
        }
        .style53
        {
            width: 94px;
            height: 32px;
        }
        .style54
        {
            width: 94px;
            height: 34px;
        }
        .style55
        {
            width: 824px;
            height: 139px;
        }
        .style56
        {
            width: 909px;
            height: 139px;
        }
        .style57
        {
            width: 764px;
            height: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
        <tr>
            <td align="center" class="style51">
                &nbsp;</td>
            <td align="center" class="style50">
                &nbsp;</td>
            <td align="center" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style51">
                &nbsp;</td>
            <td align="center" class="style50">
                <asp:Label ID="lblClientes" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Clientes"></asp:Label>
            </td>
            <td align="center" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style51">
                &nbsp;</td>
            <td align="center" class="style50">
                &nbsp;</td>
            <td align="center" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="justify" class="style55">
                </td>
            <td align="justify" class="style56">
                <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Dni" DataSourceID="odsClientes" 
                    onselectedindexchanged="gvClientes_SelectedIndexChanged" 
                    style="margin-right: 0px" Width="907px" TabIndex="8" CellPadding="4" 
                    GridLines="Horizontal" BackColor="White" 
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField SelectText="Editar" ShowSelectButton="True" >
                            <ControlStyle ForeColor="Blue" />
                        </asp:CommandField>
                        <asp:BoundField DataField="Dni" HeaderText="Dni" SortExpression="Dni" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                            SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" 
                            SortExpression="Apellido" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                            SortExpression="Telefono" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" 
                            SortExpression="Direccion" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        
                        <asp:TemplateField>
                        <ItemTemplate>
                        <asp:LinkButton ID="delete" Runat="server" OnClientClick="return confirm('¿Desea eliminar el registro?');" CommandName="Delete">Eliminar
                        </asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField> 
                        
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </td>
            <td align="justify" class="style57">
                </td>
        </tr>
        <tr>
            <td align="justify" class="style51">
                &nbsp;</td>
            <td align="right" class="style50">
                <asp:LinkButton ID="lbtnAñadirNuevo" runat="server" 
                    onclick="lbtnAñadirNuevo_Click" TabIndex="9">Añadir nuevo</asp:LinkButton>
            </td>
            <td align="justify" class="style48">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style51">
                &nbsp;</td>
            <td class="style50">
                <br />
                <table class="style7">
                    <tr>
                        <td class="style43">
                            &nbsp;</td>
                        <td class="style45">
                            &nbsp;</td>
                        <td class="style52">
                            &nbsp;</td>
                        <td class="style44">
                            &nbsp;</td>
                        <td class="style37">
                            &nbsp;</td>
                        <td class="style40">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style13">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style43" rowspan="6">
                            &nbsp;</td>
                        <td class="style45" rowspan="6">
                            <asp:Image ID="imgCliente" runat="server" Height="185px" 
                                ImageUrl="~/Imagenes/Persona.JPG" Visible="False" Width="164px" />
                        </td>
                        <td class="style52">
                        </td>
                        <td class="style44">
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre" Visible="False"></asp:Label>
                        </td>
                        <td class="style37">
                            <asp:TextBox ID="txtNombre" runat="server" Visible="False" Width="199px" 
                                TabIndex="10"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="2">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnGuardar" runat="server" Height="33px" 
                                onclick="btnGuardar_Click" Text="Guardar" Visible="False" Width="82px" 
                                TabIndex="16" />
                        </td>
                        <td class="style13" rowspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style53">
                        </td>
                        <td class="style21">
                            <asp:Label ID="lblApellido" runat="server" Text="Apellido" Visible="False"></asp:Label>
                        </td>
                        <td class="style38">
                            <asp:TextBox ID="txtApellido" runat="server" Visible="False" Width="197px" 
                                TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style53">
                        </td>
                        <td class="style21">
                            <asp:Label ID="lblNumeroDoc" runat="server" Text="Número de documento" 
                                Visible="False"></asp:Label>
                        </td>
                        <td class="style38">
                            <asp:TextBox ID="txtNroDoc" runat="server" ReadOnly="True" Visible="False" 
                                Width="197px" TabIndex="12"></asp:TextBox>
                        </td>
                        <td class="style41">
                            &nbsp;</td>
                        <td class="style35">
                            <asp:Button ID="btnAñadir" runat="server" Height="33px" 
                                onclick="btnAñadir_Click" Text="Añadir" Visible="False" Width="82px" 
                                TabIndex="17" />
                        </td>
                        <td class="style26">
                        </td>
                    </tr>
                    <tr>
                        <td class="style27">
                        </td>
                        <td class="style28">
                            <asp:Label ID="lblDireccion" runat="server" Text="Dirección" Visible="False"></asp:Label>
                        </td>
                        <td class="style29">
                            <asp:TextBox ID="txtDireccion" runat="server" Visible="False" Width="196px" 
                                TabIndex="13"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="2">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnCancelar" runat="server" Height="33px" 
                                onclick="btnCancelar_Click" Text="Cancelar" Visible="False" Width="82px" 
                                TabIndex="18" />
                        </td>
                        <td class="style13" rowspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td class="style18">
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Visible="False"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:TextBox ID="txtTelefono" runat="server" Visible="False" Width="195px" 
                                TabIndex="14"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style54">
                        </td>
                        <td class="style32">
                            <asp:Label ID="lblEmail" runat="server" Text="Email" Visible="False"></asp:Label>
                        </td>
                        <td class="style39">
                            <asp:TextBox ID="txtEmail" runat="server" Visible="False" Width="193px" 
                                TabIndex="15"></asp:TextBox>
                        </td>
                        <td class="style42">
                            &nbsp;</td>
                        <td class="style36">
                        </td>
                        <td class="style30">
                        </td>
                    </tr>
                    <tr>
                        <td class="style43">
                            &nbsp;</td>
                        <td class="style45" colspan="4">
                            <asp:Label ID="lblAdvertencia" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </td>
                        <td class="style40">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style13">
                            &nbsp;</td>
                    </tr>
                </table>
                <br />
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style51">
                &nbsp;</td>
            <td class="style50">
                <asp:ObjectDataSource ID="odsClientes" runat="server" SelectMethod="GetAll" 
                    TypeName="Data.Database.ClienteAdapter" DeleteMethod="Quitar">
                    <DeleteParameters>
                        <asp:Parameter Name="Dni" Type="String" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

