<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoMain.aspx.cs" Inherits="WEBGUI.alumnoMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 50%;
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
</table>
</asp:Content>
