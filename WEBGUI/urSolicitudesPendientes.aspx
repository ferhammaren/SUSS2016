<%@ Page Title="" Language="C#" MasterPageFile="~/UnidadReceptora.Master" AutoEventWireup="true" CodeBehind="urSolicitudesPendientes.aspx.cs" Inherits="SUSS2016.urSolicitudesPendientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="idSolicitud" HeaderText="Id Solicitud" />
            <asp:BoundField DataField="matricula" HeaderText="Matricula" />
            <asp:HyperLinkField DataNavigateUrlFields="horarioAlumno" HeaderText="Horario Alumno" Text="Ver horario" />
            <asp:HyperLinkField DataNavigateUrlFields="horarioPrestacion" HeaderText="Horario Prestacion" Text="Ver horario" />
           <asp:TemplateField>
    <ItemTemplate>
        <asp:Button ID="btnApp" runat="server" Text="Aprobar" 
                    OnClick="MyButtonClick" />
    </ItemTemplate>
</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getPendientes" TypeName="SUSS2016.CLASES.unidadReceptora"></asp:ObjectDataSource>
</asp:Content>
