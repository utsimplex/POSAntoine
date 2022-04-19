<%@ Page Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="Usuarios" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style50
        {
            width: 1116px;
        }
        .style55
        {
            width: 576px;
            height: 109px;
        }
        .style56
        {
            width: 1116px;
            height: 109px;
        }
        .style57
        {
            width: 764px;
            height: 109px;
        }
        .style48
        {
            width: 764px;
        }
        .style43
        {
            width: 408px;
        }
        .style52
        {
            width: 94px;
        }
        .style44
        {
            width: 396px;
        }
        .style37
        {
            width: 137px;
        }
        .style40
        {
        }
        .style34
        {
            width: 86px;
        }
        .style13
        {
            width: 419px;
        }
        .style65
        {
            height: 30px;
            width: 396px;
        }
        .style69
        {
            width: 396px;
            height: 27px;
        }
        .style70
        {
            width: 94px;
            height: 27px;
        }
        .style71
        {
            width: 137px;
            height: 27px;
        }
        .style72
        {
            width: 94px;
            height: 24px;
        }
        .style73
        {
            width: 396px;
            height: 24px;
        }
        .style74
        {
            width: 137px;
            height: 24px;
        }
        .style75
        {
            width: 94px;
            height: 28px;
        }
        .style76
        {
            height: 28px;
            width: 396px;
        }
        .style77
        {
            width: 137px;
            height: 28px;
        }
        .style78
        {
            width: 94px;
            height: 30px;
        }
        .style79
        {
            width: 137px;
            height: 30px;
        }
        .style80
        {
            height: 32px;
        }
        .style81
        {
            width: 94px;
            height: 32px;
        }
        .style82
        {
            width: 396px;
            height: 32px;
        }
        .style83
        {
            width: 137px;
            height: 32px;
        }
        .style84
        {
            width: 86px;
            height: 32px;
        }
        .style85
        {
            width: 419px;
            height: 32px;
        }
        .style86
        {
        }
        .style87
        {
            width: 94px;
            height: 34px;
        }
        .style88
        {
            width: 396px;
            height: 34px;
        }
        .style89
        {
            width: 137px;
            height: 34px;
        }
        .style90
        {
            width: 86px;
            height: 34px;
        }
        .style91
        {
            width: 419px;
            height: 34px;
        }
        .style92
        {
            width: 576px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
        <tr>
            <td align="center" class="style92">
                &nbsp;</td>
            <td align="center" class="style50">
                &nbsp;</td>
            <td align="center" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style92">
                &nbsp;</td>
            <td align="center" class="style50">
                <asp:Label ID="lblUsuarios" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Usuarios"></asp:Label>
            </td>
            <td align="center" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style92">
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
                <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="Usuario"
                    onselectedindexchanged="gvUsuarios_SelectedIndexChanged" 
                    style="margin-right: 0px" Width="1018px" TabIndex="8" 
                    DataSourceID="odsUsuarios" Height="111px" CellPadding="4" 
                    GridLines="Horizontal" BackColor="White" BorderColor="#336666" 
                    BorderStyle="Double" BorderWidth="3px">
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField SelectText="Editar" ShowSelectButton="True">
                        <ControlStyle ForeColor="Blue" Width="45px" />
                        </asp:CommandField>
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" 
                            SortExpression="usuario" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                            SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" 
                            SortExpression="Apellido" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                            SortExpression="Telefono" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Cuil" HeaderText="Cuil" SortExpression="Cuil" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" 
                            SortExpression="Direccion" />
                        
                        <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol" />
                        
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
            <td align="justify" class="style92">
                &nbsp;</td>
            <td align="right" class="style50">
                <asp:LinkButton ID="lbtnAñadirNuevo" runat="server" 
                    onclick="lbtnAñadirNuevo_Click" TabIndex="9" ForeColor="Blue">Añadir nuevo </asp:LinkButton>
            </td>
            <td align="justify" class="style48">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style92">
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
                        <td class="style43" rowspan="10">
                            &nbsp;</td>
                        <td class="style45" rowspan="6" valign="top">
                            <asp:Image ID="imgUsuario" runat="server" Height="185px" 
                                ImageUrl="~/Imagenes/Persona.JPG" Visible="False" Width="164px" />
                        </td>
                        <td class="style72">
                        </td>
                        <td class="style73">
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario" Visible="False"></asp:Label>
                        </td>
                        <td class="style74">
                            <asp:TextBox ID="txtUsuario" runat="server" Visible="False" Width="199px" 
                                TabIndex="10" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="6">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnGuardar" runat="server" Height="33px" 
                                onclick="btnGuardar_Click" Text="Guardar" Visible="False" Width="82px" 
                                TabIndex="21" />
                        </td>
                        <td class="style13" rowspan="6">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style70">
                        </td>
                        <td class="style69">
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre" Visible="False"></asp:Label>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txtNombre" runat="server" Visible="False" Width="199px" 
                                TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style75">
                        </td>
                        <td class="style76">
                            <asp:Label ID="lblApellido" runat="server" Text="Apellido" Visible="False"></asp:Label>
                        </td>
                        <td class="style77">
                            <asp:TextBox ID="txtApellido" runat="server" Visible="False" Width="197px" 
                                TabIndex="12"></asp:TextBox>
                        </td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnAñadir" runat="server" Height="33px" 
                                onclick="btnAñadir_Click" Text="Añadir" Visible="False" Width="82px" 
                                TabIndex="22" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style78">
                        </td>
                        <td class="style65">
                            <asp:Label ID="lblCuil" runat="server" Text="Cuil" 
                                Visible="False"></asp:Label>
                        </td>
                        <td class="style79">
                            <asp:TextBox ID="txtCuil" runat="server" Visible="False" 
                                Width="197px" TabIndex="13"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style87">
                        </td>
                        <td class="style88">
                            <asp:Label ID="lblDireccion" runat="server" Text="Dirección" Visible="False"></asp:Label>
                        </td>
                        <td class="style89">
                            <asp:TextBox ID="txtDireccion" runat="server" Visible="False" Width="197px" 
                                TabIndex="14"></asp:TextBox>
                        </td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnCancelar" runat="server" Height="33px" 
                                onclick="btnCancelar_Click" Text="Cancelar" Visible="False" Width="82px" 
                                TabIndex="23" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style70">
                        </td>
                        <td class="style69">
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Visible="False"></asp:Label>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txtTelefono" runat="server" Visible="False" Width="199px" 
                                TabIndex="16"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style45">
                            <asp:Label ID="lblRol" runat="server" Text="Rol de usuario" Visible="False"></asp:Label>
                        </td>
                        <td class="style52">
                        </td>
                        <td class="style44">
                            <asp:Label ID="lblEmail" runat="server" Text="Email" Visible="False"></asp:Label>
                        </td>
                        <td class="style37">
                            <asp:TextBox ID="txtEmail" runat="server" Visible="False" Width="198px" 
                                TabIndex="17"></asp:TextBox>
                        </td>
                        <td class="style40">
                            </td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style13">
                        </td>
                    </tr>
                    <tr>
                        <td class="style86" rowspan="2">
                            <asp:RadioButtonList ID="rbtnRol" runat="server" Visible="False">
                                <asp:ListItem>Administrador</asp:ListItem>
                                <asp:ListItem>Empleado</asp:ListItem>
                                <asp:ListItem>Externo</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td class="style87">
                        </td>
                        <td class="style88">
                <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" Visible="False"></asp:Label>
                        </td>
                        <td class="style89">
                <asp:TextBox ID="txtContraseña" runat="server" Width="199px" 
                                TabIndex="18" TextMode="Password" Visible="False"></asp:TextBox>
                        </td>
                        <td class="style86">
                            </td>
                        <td class="style90">
                            </td>
                        <td class="style91">
                        </td>
                    </tr>
                    <tr>
                        <td class="style81">
                        </td>
                        <td class="style82">
                <asp:Label ID="lblNuevaContraseña" runat="server" Text="Nueva contraseña" Visible="False"></asp:Label>
                        </td>
                        <td class="style83">
                <asp:TextBox ID="txtNuevaContraseña" runat="server" Width="199px" 
                                TabIndex="19" TextMode="Password" Visible="False"></asp:TextBox>
                        </td>
                        <td class="style80">
                            </td>
                        <td class="style84">
                            </td>
                        <td class="style85">
                        </td>
                    </tr>
                    <tr>
                        <td class="style86">
                            </td>
                        <td class="style87">
                        </td>
                        <td class="style88">
                <asp:Label ID="lblRepContraseña" runat="server" Text="Repetir contraseña" Visible="False"></asp:Label>
                        </td>
                        <td class="style89">
                <asp:TextBox ID="txtRepContraseña" runat="server" Width="199px" 
                                TabIndex="20" TextMode="Password" Visible="False"></asp:TextBox>
                        </td>
                        <td class="style86">
                            </td>
                        <td class="style90">
                            </td>
                        <td class="style91">
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
            <td class="style92">
                &nbsp;</td>
            <td class="style50" id="odsUsuarios">
                <asp:ObjectDataSource ID="odsUsuarios" runat="server" DeleteMethod="Quitar" 
                    SelectMethod="GetAll" TypeName="Data.Database.UsuarioAdapter">
                    <DeleteParameters>
                        <asp:Parameter Name="usuario" Type="String" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

