<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoReporte.aspx.cs" Inherits="WEBGUI.alumnoReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Etapa de Servicio Social"></asp:Label>
    <br />
    <asp:DropDownList ID="etapaReporte" runat="server" CssClass="auto-style6">
        <asp:ListItem>Primera Etapa</asp:ListItem>
        <asp:ListItem>Segunda Etapa</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Tipo de Reporte"></asp:Label>
<br />
    <asp:DropDownList ID="tipoReporte" runat="server">
        <asp:ListItem>Trimestral</asp:ListItem>
        <asp:ListItem>Final</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Reporte a subir"></asp:Label>
<br />
    <asp:FileUpload ID="elegirReporte" runat="server" />
    <br />
<asp:Button ID="subirReporte" runat="server" OnClick="subirReporte_Click" Text="Subir Reporte" />
    <br />
    <br />
    <br />
<br />
</asp:Content>
