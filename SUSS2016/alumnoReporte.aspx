<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno.Master" AutoEventWireup="true" CodeBehind="alumnoReporte.aspx.cs" Inherits="WEBGUI.alumnoReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Subir tu reporte de Servicio Social sólo con formatos .doc, .docx, .pdf"></asp:Label>
<br />
<asp:FileUpload ID="eligeReporte" runat="server" />
<br />
<asp:Button ID="subirReporte" runat="server" OnClick="subirReporte_Click" Text="Subir Reporte" />
<br />
<br />
</asp:Content>
