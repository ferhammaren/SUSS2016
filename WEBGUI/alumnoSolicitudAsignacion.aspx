<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoSolicitudAsignacion.aspx.cs" Inherits="WEBGUI.alumnoSolicitudAsignacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>Solicitar Asignación</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Datos del Programa"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
                                    &nbsp;</td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# BIND("nombrePrograma") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Etapa</td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# BIND("ETAPA") %>'></asp:Label>
                                </td>
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
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:FormView>
                        <table class="auto-style1" __designer:mapid="1b2">
                            <tr __designer:mapid="1b3">
                                <td __designer:mapid="1b4">Fecha de Asignación<br __designer:mapid="1b5" />
                                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                </td>
                                <td __designer:mapid="1b7">&nbsp;</td>
                                <td __designer:mapid="1b8">&nbsp;</td>
                                <td __designer:mapid="1b9">&nbsp;</td>
                                <td __designer:mapid="1ba">Fecha Estimada de conclusión<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                                </td>
                            </tr>
                            <tr __designer:mapid="1bc">
                                <td __designer:mapid="1bd">&nbsp;</td>
                                <td __designer:mapid="1be">&nbsp;</td>
                                <td __designer:mapid="1bf">&nbsp;</td>
                                <td __designer:mapid="1c0">&nbsp;</td>
                                <td __designer:mapid="1c1">&nbsp;</td>
                            </tr>
                            <tr __designer:mapid="1c2">
                                <td __designer:mapid="1c3">Horario de prestación</td>
                                <td __designer:mapid="1c4">&nbsp;</td>
                                <td __designer:mapid="1c5">
                                   
                                    <asp:FileUpload ID="fuHoraPrestacion" accept="text/" runat="server" />
                                </td>
                                <td __designer:mapid="1c7">
                                    <asp:Button ID="btnPrestacion" runat="server" OnClick="btnPrestacion_Click" Text="Subir Archivo" />
                                    <asp:Label ID="statusLabel" runat="server"></asp:Label>
                                </td>
                                <td __designer:mapid="1c8">Descargar formato de horario</td>
                            </tr>
                            <tr __designer:mapid="1c9">
                                <td __designer:mapid="1ca">Horario de clases</td>
                                <td __designer:mapid="1cb">&nbsp;</td>
                                <td __designer:mapid="1cc">
                                  
                                    <asp:FileUpload ID="fuHoraClases" accept="text/" runat="server" />
                                </td>
                                <td __designer:mapid="1ce">
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subir Archivo" />
                                    <asp:Label ID="statusLabel1" runat="server"></asp:Label>
                                </td>
                                <td __designer:mapid="1cf">Descargar horario de clases</td>
                            </tr>
                            <tr __designer:mapid="1d0">
                                <td __designer:mapid="1d1">
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnCommand="Button1_Command" Text="Enviar Solicitud de Asignación" />
                                </td>
                                <td __designer:mapid="1d2">&nbsp;</td>
                                <td __designer:mapid="1d3">&nbsp;</td>
                                <td __designer:mapid="1d4">&nbsp;</td>
                                <td __designer:mapid="1d5">&nbsp;</td>
                            </tr>
                        </table>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectSingle" TypeName="DA.PROGRAMASERVICIOSOCIAL">
                    <SelectParameters>
                        <asp:SessionParameter Name="idPrograma" SessionField="programaSelected" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
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
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
