<%@ Page Title="" Language="C#" MasterPageFile="~/UnidadAcademica.Master" AutoEventWireup="true" CodeBehind="uaReportesPendientes.aspx.cs" Inherits="WEBGUI.uaReportesPendientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    <br />
</p>
<p>
</p>
</asp:Content>
