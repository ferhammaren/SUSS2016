<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoCatalogoProgramas.aspx.cs" Inherits="WEBGUI.alumnoCatalogoProgramas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ObjectDataSource ID="programas" runat="server" SelectMethod="SelectAll" TypeName="DA.PROGRAMASERVICIOSOCIAL"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="programas">
        <Columns>
            <asp:BoundField DataField="nombrePrograma" HeaderText="Nombre del Programa" />
            <asp:BoundField DataField="etapa" HeaderText="Etapa" />
            <asp:ButtonField Text="Solicitar Asignación" />
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
