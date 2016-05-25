<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoMain.aspx.cs" Inherits="WEBGUI.alumnoMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table style="width:100%">
        <tr>
            <td>
                <asp:FormView ID="FormView1" runat="server" Width="100%" DataSourceID="infoAlumno">
                    <ItemTemplate>
                        <table class="placeholder">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Unidad Académica"></asp:Label>
                                    :
                                    <asp:Label ID="Label2" runat="server" Text='<%# BIND("descripcion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Programa Educativo: "></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text='<%# BIND("descripcion") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Acreditación 1ra etapa: "></asp:Label>
                                    <asp:Label ID="Label6" runat="server" Text='<%# BIND("fechaAcPrimeraEtapa") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Acreditación 2da Etapa: "></asp:Label>
                                    <asp:Label ID="Label8" runat="server" Text='<%# BIND("fechaAcSegundaEtapa") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Horas 1ra etapa:
                                    <asp:Label ID="Label9" runat="server" Text='<%# BIND("horasPrimeraEtapa") %>'></asp:Label>
                                </td>
                                <td>Horas 2da etapa:
                                    <asp:Label ID="Label10" runat="server" Text='<%# BIND("horasSegundaEtapa") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Créditos por carrera:
                                    <asp:Label ID="Label11" runat="server" Text='<%# BIND("creditosTotales") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Créditos acumulados:
                                    <asp:Label ID="Label12" runat="server" Text='<%# BIND("creditosCumplidos") %>'></asp:Label>
                                </td>
                                <td>&nbsp;% de créditos acumulados: &nbsp;<asp:Label ID="Label13" runat="server"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:FormView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="infoAlumno" runat="server" SelectMethod="getAlumno" TypeName="SUSS2016.CLASES.Alumnos"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>Programa Activo<br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="programaActivo">
                    <Columns>
                        <asp:BoundField HeaderText="Id Programa" />
                        <asp:BoundField HeaderText="Nombre del Programa" DataField="nombrePrograma" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnGenerar" runat="server" OnClick="MyButtonClick" Text="Generar Reporte" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:ObjectDataSource ID="programaActivo" runat="server" SelectMethod="SelectActivo" TypeName="SUSS2016.DA.PROGRAMASASIGNADOS">
                    <SelectParameters>
                        <asp:SessionParameter Name="matricula" SessionField="matriculaAlumno" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Programas Completados<br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="programasPasados" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="etapa" HeaderText="Etapa" />
                        <asp:BoundField DataField="nombrePrograma" HeaderText="Programa" />
                        <asp:BoundField DataField="horas" HeaderText="Horas Acreditadas" />
                        <asp:BoundField DataField="fechaFin" HeaderText="Fecha de finalización" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="programasPasados" runat="server" SelectMethod="SelectAll" TypeName="SUSS2016.DA.PROGRAMASASIGNADOS">
                    <SelectParameters>
                        <asp:SessionParameter Name="matricula" SessionField="matriculaAlumno" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
   
</asp:Content>
