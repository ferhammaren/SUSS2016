<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoMain.aspx.cs" Inherits="WEBGUI.alumnoMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 50%;
    }
        .auto-style6 {
            width: 512px;
            height: 37px;
        }
        .auto-style7 {
            width: 100%;
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td style="width: 100%">
            <asp:FormView ID="FormView1" runat="server">
            </asp:FormView>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td style="width: 100%">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td style="width: 100%">Programa Activo<br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="Id Programa" />
                    <asp:BoundField HeaderText="Nombre del Programa" />
                     <asp:TemplateField>
    <ItemTemplate>
        <asp:Button ID="btnGenerar" runat="server" Text="Generar Reporte" 
                    OnClick="MyButtonClick" />
    </ItemTemplate>
</asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style7">
            <asp:ObjectDataSource ID="programaActivo" runat="server"></asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td style="width: 100%">Programas Completados<br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nombrePrograma" HeaderText="Programa" />
                    <asp:BoundField DataField="horas" HeaderText="Horas Acreditadas" />
                    <asp:BoundField DataField="etapa" HeaderText="Etapa" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="programasPasados" runat="server" SelectMethod="SelectAll" TypeName="SUSS2016.DA.PROGRAMASASIGNADOS"></asp:ObjectDataSource>
        </td>
    </tr>
</table>
</asp:Content>
