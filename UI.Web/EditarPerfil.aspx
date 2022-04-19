<%@ Page Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="EditarPerfil.aspx.cs" Inherits="EditarPerfil" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

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
        .style28
        {
            height: 33px;
        }
        .style67
        {
            width: 94px;
            height: 33px;
        }
        .style68
        {
            width: 137px;
            height: 33px;
        }
        .style53
        {
            width: 94px;
            height: 32px;
        }
        .style21
        {
            height: 32px;
            width: 396px;
        }
        .style38
        {
            width: 137px;
            height: 32px;
        }
        .style54
        {
            width: 94px;
            height: 34px;
        }
        .style32
        {
            height: 34px;
            width: 396px;
        }
        .style39
        {
            width: 137px;
            height: 34px;
        }
        .style42
        {
            width: 69px;
            height: 34px;
        }
        .style36
        {
            width: 86px;
            height: 34px;
        }
        .style30
        {
            width: 419px;
            height: 34px;
        }
        .style80
        {
            font-size: x-large;
            font-weight: bold;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
        <tr>
            <td class="style43">
                        &nbsp;</td>
            <td class="style45" colspan="4">
                        &nbsp;</td>
            <td class="style40">
                        &nbsp;</td>
            <td class="style34">
                        &nbsp;</td>
            <td class="style13">
                        &nbsp;</td>
        </tr>
        <tr>
            <td class="style43">
                        &nbsp;</td>
            <td class="style80" colspan="4">
                        Modificación del usuario</td>
            <td class="style40">
                        &nbsp;</td>
            <td class="style34">
                        &nbsp;</td>
            <td class="style13">
                        &nbsp;</td>
        </tr>
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
                                TabIndex="10" ReadOnly="True"></asp:TextBox>
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
                <asp:Button ID="btnCancelar" runat="server" Height="33px" 
                                onclick="btnCancelar_Click" Text="Cancelar" Width="82px" 
                                TabIndex="23" />
            </td>
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
                        &nbsp;</td>
        </tr>
        <tr>
            <td class="style70">
            </td>
            <td class="style69">
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td class="style71">
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
            <td class="style28">
                            &nbsp;</td>
            <td class="style67">
            </td>
            <td class="style28">
                <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td class="style68">
                <asp:TextBox ID="txtContraseña" runat="server" Width="199px" 
                                TabIndex="18" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style28" colspan="3">
                            &nbsp;</td>
        </tr>
        <tr>
            <td class="style45">
                            &nbsp;</td>
            <td class="style53">
            </td>
            <td class="style21">
                <asp:Label ID="lblNuevaContraseña" runat="server" Text="Nueva contraseña"></asp:Label>
            </td>
            <td class="style38">
                <asp:TextBox ID="txtNuevaContraseña" runat="server" Width="199px" 
                                TabIndex="19" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style40" colspan="3">
                            &nbsp;</td>
        </tr>
        <tr>
            <td class="style45">
                            &nbsp;</td>
            <td class="style54">
            </td>
            <td class="style32">
                <asp:Label ID="lblRepContraseña" runat="server" Text="Repetir contraseña"></asp:Label>
            </td>
            <td class="style39">
                <asp:TextBox ID="txtRepContraseña" runat="server" Width="199px" 
                                TabIndex="20" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style42">
                            &nbsp;</td>
            <td class="style36">
                            &nbsp;</td>
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
</asp:Content>

