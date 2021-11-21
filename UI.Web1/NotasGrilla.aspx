<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NotasGrilla.aspx.cs" Inherits="UI.Web1.NotasGrilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:DropDownList ID="ddlBuscar" runat="server" DataSourceID="SqlDataSource2" DataTextField="id_curso" DataValueField="id_curso" OnSelectedIndexChanged="ddlBuscar_SelectedIndexChanged" AutoPostBack="True">
</asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:UI.Desktop.Properties.Settings.tp2_netConnectionString %>" SelectCommand="SELECT [id_curso] FROM [cursos]"></asp:SqlDataSource>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_inscripcion" DataSourceID="SqlDataSource1" OnRowUpdating="GridView1_RowUpdating" OnRowUpdated="GridView1_RowUpdated">
       
        <Columns>
            
            <asp:TemplateField HeaderText="id_inscripcion" InsertVisible="False" SortExpression="id_inscripcion">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("id_inscripcion") %>' Enabled="False"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("id_inscripcion") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="id_alumno" SortExpression="id_alumno">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_alumno") %>' ReadOnly="True" Enabled="False"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("id_alumno") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="nombre" SortExpression="nombre">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nombre") %>' ReadOnly="True" Enabled="False"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="apellido" SortExpression="apellido">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("apellido") %>' ReadOnly="True" Enabled="False" EnableTheming="True"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("apellido") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="id_curso" SortExpression="id_curso">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("id_curso") %>'  ReadOnly="True" Enabled="False"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("id_curso") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="condicion" SortExpression="condicion">
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Bind("condicion") %>'>
                        <asp:ListItem Value="0">Libre</asp:ListItem>
                        <asp:ListItem Value="1">Regular</asp:ListItem>
                        <asp:ListItem Value="2">AD</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("condicion") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="nota" SortExpression="nota">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("nota") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("nota") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UI.Desktop.Properties.Settings.tp2_netConnectionString %>" SelectCommand="ListasAlumnosInscripcion" SelectCommandType="StoredProcedure" UpdateCommand="ListasAlumnosInscripcion" FilterExpression="id_curso ='{0}'"> 
       <FilterParameters>
           <asp:ControlParameter Name="id_curso" ControlID="ddlBuscar" PropertyName="SelectedValue"  />
   </FilterParameters>

    </asp:SqlDataSource>
</asp:Content>
