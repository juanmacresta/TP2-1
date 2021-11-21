<%@ Page Title="EditNota" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GrillaNotas.aspx.cs" Inherits="UI.Web1.GrillaNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_inscripcion" DataSourceID="SqlDataSource1" OnRowUpdating="GridView1_RowUpdating1">
        <Columns>
            <asp:TemplateField HeaderText="id_inscripcion" SortExpression="id_inscripcion" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl7" runat="server" DataField="id_inscripcion" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl7" runat="server" DataField="id_inscripcion" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="id_alumno" SortExpression="id_alumno" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl6" runat="server" DataField="id_alumno" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl6" runat="server" DataField="id_alumno" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="nombre" SortExpression="nombre" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl5" runat="server" DataField="nombre" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl5" runat="server" DataField="nombre" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="apellido" SortExpression="apellido" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl4" runat="server" DataField="apellido" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl4" runat="server" DataField="apellido" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="id_curso" SortExpression="id_curso" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl3" runat="server" DataField="id_curso" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl3" runat="server" DataField="id_curso" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="condicion" SortExpression="condicion" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="condicion" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="condicion" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="nota" SortExpression="nota" ConvertEmptyStringToNull="False">
                <EditItemTemplate>
                    <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="nota" Mode="Edit" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="nota" Mode="ReadOnly" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UI.Desktop.Properties.Settings.tp2_netConnectionString %>" DeleteCommand="ListasAlumnosInscripcion" DeleteCommandType="StoredProcedure" InsertCommand="ListasAlumnosInscripcion" InsertCommandType="StoredProcedure" SelectCommand="ListasAlumnosInscripcion" SelectCommandType="StoredProcedure" UpdateCommand="ListasAlumnosInscripcion" ></asp:SqlDataSource>
</asp:Content>



