<%@ Page Title="Sistema Universitario de Servicio Social UABC" Language="C#" MasterPageFile="~/Generic.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEBGUI.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
    <table width="80%" align="center">
      <tr>
        <td>
          <asp:Button Text="Alumnos" BorderStyle="None" ID="tabAlumnos" CssClass="Initial" runat="server"
              OnClick="Tab1_Click" />
          <asp:Button Text="Unidades Académicas" BorderStyle="None" ID="tabUA" CssClass="Initial" runat="server"
              OnClick="Tab2_Click" />
          <asp:Button Text="Unidades Receptoras" BorderStyle="None" ID="tabUR" CssClass="Initial" runat="server"
              OnClick="Tab3_Click" />
          <asp:MultiView ID="MainView" runat="server">
            <asp:View ID="View1" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td style="text-align: center; vertical-align: middle">
                    
                      Inicio de sesión para Alumnos</td>
                    <tr>
                        <td style="text-align: center; vertical-align: middle">

                            <asp:Label ID="Label1" runat="server" Text="Correo UABC: "></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="tbAlCorreo" runat="server"></asp:TextBox>

                        </td>
                        <tr>
                            <td style="text-align: center; vertical-align: middle">
                                <asp:Label ID="Label2" runat="server" Text="Contraseña: "></asp:Label>
                                &nbsp;<asp:TextBox ID="tbAlPass" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; vertical-align: middle">
                                <asp:Button ID="tbAlLogin" runat="server" OnClick="tbAlLogin_Click" Text="Iniciar Sesión" />
                            </td>
                        </tr>
                    </tr>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td class="auto-style2">
                      Inicio de sesión para Unidad Académica<tr>
                  <td style="text-align: center; vertical-align: middle">
                    
                      <asp:Label ID="Label3" runat="server" Text="Correo UABC: "></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="tbUACorreo" runat="server"></asp:TextBox>
                    
                  </td>
                    <tr>
                        <td style="text-align: center; vertical-align: middle">

                            <asp:Label ID="Label4" runat="server" Text="Contraseña: "></asp:Label>
                            <input id="tbUAPass" type="password" />

                        </td>
                    </tr>
                    <tr>
<td style="text-align: center; vertical-align: middle">

    <asp:Button ID="btnUALogin" runat="server" Text="Iniciar Sesión" OnClick="btnUALogin_Click" />

</td>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View3" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                      Inicio de sesión para Unidad Receptora<tr>
                  <td style="text-align: center; vertical-align: middle">
                    
                      <asp:Label ID="Label5" runat="server" Text="Correo UABC: "></asp:Label>
                      &nbsp;&nbsp;&nbsp;
                      <asp:TextBox ID="tbURCorreo" runat="server"></asp:TextBox>
                    
                  </td>
                    <tr>
                        <td style="text-align: center; vertical-align: middle">

                            <asp:Label ID="Label6" runat="server" Text="Contraseña: "></asp:Label>
                            <input id="tbURPass" type="password" />

                        </td>
                    </tr>
                    <tr>
<td style="text-align: center; vertical-align: middle">

    <asp:Button ID="tbURLogin" runat="server" Text="Iniciar Sesión" OnClick="tbURLogin_Click" />

</td>
                  </td>
                </tr>
              </table>
            </asp:View>
          </asp:MultiView>
        </td>
      </tr>
    </table>
  </form></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
