<%@ Page Title="" Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="NuevoUsuario.aspx.cs" Inherits="NuevoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style50
        {
            width: 1116px;
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
        .style34
        {
            width: 86px;
        }
        .style13
        {
            width: 419px;
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
        .style70
        {
            width: 94px;
            height: 27px;
        }
        .style69
        {
            width: 396px;
            height: 27px;
        }
        .style71
        {
            width: 137px;
            height: 27px;
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
        .style65
        {
            height: 30px;
            width: 396px;
        }
        .style79
        {
            width: 137px;
            height: 30px;
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
        .style80
        {
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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
        <tr>
            <td align="center" class="style50">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style50">
                <asp:Label ID="lblUsuarios" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Usuarios"></asp:Label>
            </td>
        </tr>
        <tr>
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
                                ImageUrl="~/Imagenes/Persona.JPG" Width="164px" />
                        </td>
                        <td class="style72">
                        </td>
                        <td class="style73">
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                        </td>
                        <td class="style74">
                            <asp:TextBox ID="txtUsuario" runat="server" Width="199px" 
                                TabIndex="10"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="6">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnGuardar" runat="server" Height="33px" 
                                onclick="btnGuardar_Click" Text="Guardar" Width="82px" 
                                TabIndex="21" />
                        </td>
                        <td class="style13" rowspan="6">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style70">
                        </td>
                        <td class="style69">
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txtNombre" runat="server" Width="199px" 
                                TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style75">
                        </td>
                        <td class="style76">
                            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                        </td>
                        <td class="style77">
                            <asp:TextBox ID="txtApellido" runat="server" Width="197px" 
                                TabIndex="12"></asp:TextBox>
                        </td>
                        <td class="style34" rowspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style78">
                        </td>
                        <td class="style65">
                            <asp:Label ID="lblCuil" runat="server" Text="Cuil"></asp:Label>
                        </td>
                        <td class="style79">
                            <asp:TextBox ID="txtCuil" runat="server" 
                                Width="197px" TabIndex="13"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style78">
                        </td>
                        <td class="style65">
                            <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                        </td>
                        <td class="style79">
                            <asp:TextBox ID="txtDireccion" runat="server" Width="197px" 
                                TabIndex="14"></asp:TextBox>
                        </td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnCancelar" runat="server" Height="33px" 
                                onclick="btnCancelar_Click" Text="Cancelar" Width="82px" 
                                TabIndex="23" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style52">
                        </td>
                        <td class="style44">
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                        </td>
                        <td class="style37">
                            <asp:TextBox ID="txtTelefono" runat="server" Width="199px" 
                                TabIndex="16"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style45">
                            &nbsp;</td>
                        <td class="style52">
                        </td>
                        <td class="style44">
                            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td class="style37">
                            <asp:TextBox ID="txtEmail" runat="server" Width="198px" 
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
                            &nbsp;</td>
                        <td class="style87">
                        </td>
                        <td class="style88">
                            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
                        </td>
                        <td class="style89">
                            <asp:TextBox ID="txtContraseña" runat="server" Width="199px" 
                                TabIndex="18" TextMode="Password"></asp:TextBox>
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
                            <asp:Label ID="lblRepContraseña" runat="server" Text="Repetir contraseña"></asp:Label>
                        </td>
                        <td class="style83">
                            <asp:TextBox ID="txtRepContraseña" runat="server" Width="199px" 
                                TabIndex="20" TextMode="Password"></asp:TextBox>
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
                            &nbsp;</td>
                        <td class="style89">
                            &nbsp;</td>
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
        </tr>
    </table>
</asp:Content>

