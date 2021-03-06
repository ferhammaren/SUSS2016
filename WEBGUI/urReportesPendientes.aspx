﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UnidadReceptora.Master" AutoEventWireup="true" CodeBehind="urReportesPendientes.aspx.cs" Inherits="SUSS2016.urReportesPendientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="reportesView" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="reporteID" HeaderText="ID del reporte" />
            <asp:BoundField HeaderText="Nombre del Alumno" DataField="nombre" />
            <asp:HyperLinkField DataNavigateUrlFields="rutaReporte" HeaderText="Revisar reporte" Text="Revisar" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnApp" runat="server" Text="Aprobar"
                        OnClick="aprobar_Reporte" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="DataAccess.REPORTESPENDIENTESUR">
        <SelectParameters>
            <asp:Parameter Name="ur" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
