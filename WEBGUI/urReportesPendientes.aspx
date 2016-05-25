<%@ Page Title="" Language="C#" MasterPageFile="~/UnidadReceptora.Master" AutoEventWireup="true" CodeBehind="urReportesPendientes.aspx.cs" Inherits="SUSS2016.urReportesPendientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="reportesView" runat="server" DataSourceID="ObjectDataSource1">
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="DataAccess.REPORTESPENDIENTESUR"></asp:ObjectDataSource>
</asp:Content>
