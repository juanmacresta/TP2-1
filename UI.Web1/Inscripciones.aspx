<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web1.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="ID Curso" DataField="IDCurso" />
                <asp:BoundField HeaderText="ID Alumno" DataField="IDAlumno" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
                

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
<asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="idLabel" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="idTextBox" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="IdCursoLabel" runat="server" Text="ID Curso: "></asp:Label>
        <asp:DropDownList ID="idCursoDdl" runat="server"></asp:DropDownList>
    
        <br />
        <asp:Label ID="IdDocenteLabel" runat="server" Text="ID Alumno: "></asp:Label>
        <asp:TextBox ID="idAlumnotBox" runat="server" Width="136px"></asp:TextBox>
    
        <br />
         
        <asp:Label ID="cargo" runat="server" Text="Condicion: "></asp:Label>
        <asp:TextBox ID="condicionTBox" runat="server" Width="126px" Enabled="False" ReadOnly="True"></asp:TextBox>
        
        <br />
    <asp:Label ID="Label1" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="notaTBoc" runat="server" Width="126px" Enabled="False" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
        <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            <br />
    </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" Visible=false runat="server" OnClick="editarLinkButton_Click">Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" Visible=false runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" Visible=false runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
</asp:Content>