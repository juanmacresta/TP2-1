<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web1.Cursos" %>
<asp:Content ID="Content" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="True"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
             BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" DataKeyNames="id_curso" >
            <Columns>
                <%--<asp:BoundField HeaderText="ID Curso" DataField="ID" />
                <asp:BoundField HeaderText="ID Materia" DataField="IDMateria" />
                <asp:BoundField HeaderText="ID Comision" DataField="IDComision" />
                <asp:BoundField HeaderText="Año" DataField="AnioCalendario" />
                <asp:BoundField HeaderText="Cupo" DataField="Cupo" />--%>

                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
            
        </asp:GridView>
    </asp:Panel>
<asp:Panel ID="formPanel" Visible="false" runat="server" style="margin-top: 0px">
    <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
    <asp:TextBox ID="txtID" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
     <br />
    <asp:Label ID="lblIDMat" runat="server" Text="ID Materia:"></asp:Label>
 <asp:DropDownList ID="ddlMat" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblIdCom" runat="server" Text="ID Comision:"></asp:Label>
    <asp:DropDownList ID="ddlCom" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblAño" runat="server" Text="Año"></asp:Label>
    <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="Año" runat="server" ControlToValidate="txtAño"   
ErrorMessage="El año no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
    <asp:Label ID="lblCupo" runat="server" Text="Cupo:"></asp:Label>
    <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="cupo" runat="server" ControlToValidate="txtCupo"   
ErrorMessage="El año no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
    <br />
    </asp:Panel>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>   
          <asp:Panel ID="formActionsPanel" visible=false runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            <br />
    </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton"  Visible="false" runat="server" OnClick="editarLinkButton_Click">Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" Visible="false" runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" Visible="false" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UI.Desktop.Properties.Settings.tp2_netConnectionString %>" DeleteCommand="ListasCursos" DeleteCommandType="StoredProcedure" InsertCommand="ListasCursos" InsertCommandType="StoredProcedure" SelectCommand="ListasCursos" SelectCommandType="StoredProcedure" UpdateCommand="ListasCursos" UpdateCommandType="StoredProcedure"></asp:SqlDataSource>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
</asp:Content>
