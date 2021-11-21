<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web1.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="ID Persona" DataField="ID" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="EMail" DataField="EMail" />
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento" />
                <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" />
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
        <asp:DropDownList ID="ddlSelec" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
    </asp:Panel>
<asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="IDPersonaLabel" runat="server" Text="ID Persona: "></asp:Label>
        <asp:TextBox ID="idPersonaTextBox" runat="server" Width="126px" Enabled="False" ReadOnly="True" OnTextChanged="idPersonaTextBox_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Nombre" runat="server" ControlToValidate="nombreTextBox" ErrorMessage="El nombre no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Apellido" runat="server" ControlToValidate="apellidoTextBox" ErrorMessage="El apellido no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server" Width="138px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="clave" runat="server" ControlToValidate="legajoTextBox" ErrorMessage="El legajo no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion:  "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="Direccion" runat="server" ControlToValidate="direccionTextBox" ErrorMessage="La direccion no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="tel" runat="server" ControlToValidate="telefonoTextBox"   
ErrorMessage="El telefono no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" Width="136px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="email" runat="server" ControlToValidate="emailTextBox"   
ErrorMessage="El Email no puede estar vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
   <asp:RegularExpressionValidator
        ID="regEmail" ControlToValidate="emailTextBox" ErrorMessage="Email No válido" ForeColor="Red"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        runat="server">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="fechaNacimientoLabel" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
        <asp:TextBox ID="fechaNacTextBox" runat="server" Width="136px" TextMode="Date"></asp:TextBox>
        <asp:RequiredFieldValidator ID="fechaNac" runat="server" ControlToValidate="fechaNacTextBox"   
ErrorMessage="El formato de la fecha de nacimiento no es correcto" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan: "></asp:Label>
        <asp:DropDownList ID="ddlPlan" runat="server">
        </asp:DropDownList>
    <asp:RequiredFieldValidator ID="idPlan" runat="server" ControlToValidate="ddlPlan"   
ErrorMessage="Debe Seleccionar un plan" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Tipo Persona: "></asp:Label>
        <asp:DropDownList ID="ddlTP" runat="server" >
            <asp:ListItem Value="1">Alumno</asp:ListItem>
            <asp:ListItem Value="2">Profesor</asp:ListItem>
        </asp:DropDownList>
     <asp:RequiredFieldValidator ID="idTP" runat="server" ControlToValidate="ddlTP"   
ErrorMessage="Debe Seleccionar un Tipo" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre Usuario: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtNU" runat="server" Visible="False"></asp:TextBox>
     <asp:RequiredFieldValidator ID="NU" runat="server" ControlToValidate="txtNU"   
ErrorMessage="El nombre de usuario no puede estar vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
        <asp:Panel ID="formActionsPanel" runat="server" >
            
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            <br />
    </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnSalin" runat="server" OnClick="btnSalin_Click">Salir</asp:LinkButton>
    </asp:Panel>
</asp:Content>