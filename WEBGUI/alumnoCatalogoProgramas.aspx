<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoCatalogoProgramas.aspx.cs" Inherits="WEBGUI.alumnoCatalogoProgramas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ObjectDataSource ID="programas" runat="server" SelectMethod="SelectAll" TypeName="DA.PROGRAMASERVICIOSOCIAL"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="programas" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="idPrograma" HeaderText="ID del programa" />
            <asp:BoundField DataField="nombrePrograma" HeaderText="Nombre del Programa" />
            <asp:BoundField DataField="etapa" HeaderText="Etapa" />
            <asp:TemplateField>
    <ItemTemplate>
        <asp:Button ID="btnSolicitar" runat="server" Text="Solicitar" 
                    OnClick="MyButtonClick" />
    </ItemTemplate>
</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
