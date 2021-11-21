<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web1.Comisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="ID" />
                <asp:BoundField HeaderText="Descripcion Comision" DataField="Descripcion" />
                <asp:BoundField HeaderText="Año Especialidad" DataField="AnioEspecialidad" />
                <asp:BoundField HeaderText="Id Plan" DataField="IdPlan" />
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
        <asp:Label ID="lbID" runat="server" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" ReadOnly="True"></asp:TextBox>
        
        <br />
     <asp:Label ID="lbldesc" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDesc"   
ErrorMessage="La descripcion no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
        <asp:Label ID="lblAño" runat="server" Text="Año Especialidad:"></asp:Label>
        <asp:TextBox ID="txtAño" runat="server" Width="136px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAño"   
ErrorMessage="El año no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
        <br />
        <asp:Label ID="lblIDEsp" runat="server" Text="ID Plan:"></asp:Label>
    <asp:DropDownList ID="ddlIdPlan" runat="server"></asp:DropDownList>
        <br />
      
        <asp:Panel ID="formActionsPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
    </asp:Panel>
     
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" Visible="False" runat="server" OnClick="editarLinkButton_Click" >Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" Visible="False" runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" Visible="False" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    
</asp:Content>
