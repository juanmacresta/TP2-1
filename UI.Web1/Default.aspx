<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Web1._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel runat="server"> <div style="margin-left: auto; margin-right: auto; text-align: center;"> <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"
            CssClass="StrongText"></asp:Label>
       </div>
        </asp:Panel>
    <asp:Panel runat="server" Height="40px">  
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        &nbsp;<asp:Button Text="Personas" Visible="false" ID="btnPersona" runat="server" OnClick="btnPersona_Click" />
        &nbsp;<asp:Button Text="Usuario" Visible="false" ID="btnUsuario" runat="server" OnClick="btnUsuario_Click" />
        &nbsp;<asp:Button Text="Cursos" Visible="false" ID="btnCurso" runat="server" OnClick="btnCurso_Click" />
        &nbsp;<asp:Button Text="Comision" Visible="false" ID="btnComision" runat="server" OnClick="btnComision_Click" />
        </div>
        
    </asp:Panel>
    <asp:Panel runat="server" Height="40px">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        &nbsp;<asp:Button Text="Plan" Visible="false" ID="btnPlan" runat="server" OnClick="btnPlan_Click" />
        &nbsp;<asp:Button Text="Especialidad" Visible="false" ID="btnEspecialidad" runat="server" OnClick="btnEspecialidad_Click" />
        &nbsp;<asp:Button Text="Materia" Visible="false" ID="btnMateria" runat="server" OnClick="btnMateria_Click" />
        &nbsp;<asp:Button Text="Docente Curso" Visible="false" ID="btnDocenteCurso" runat="server" OnClick="btnDocenteCurso_Click" />
        </div>
    </asp:Panel>
    <asp:Panel runat="server" Height="40px">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        &nbsp;<asp:Button Text="Inscripcion" Visible="false" ID="btnInscripcion" runat="server" OnClick="btnInscripcion_Click" />
        &nbsp;<asp:Button Text="Reporte Curso" Visible="false" ID="btnRepCur" runat="server" OnClick="btnRepCur_Click" />
        &nbsp;<asp:Button Text="Reporte Plan" Visible="false" ID="btnRepPlan" runat="server" OnClick="btnRepPlan_Click" />
        &nbsp;<asp:Button Text="Editar Notas" Visible="false" ID="btnEditar" runat="server" OnClick="btnEditar_Click" />
            </div>
    </asp:Panel>
</asp:Content>
