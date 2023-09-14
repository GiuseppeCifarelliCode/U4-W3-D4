<%@ Page Title="" Language="C#" MasterPageFile="~/Rubrica.Master" AutoEventWireup="true" CodeBehind="modifica.aspx.cs" Inherits="Rubrica.modifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="DettagliContatto" runat="server" class="d-flex flex-column align-items-center">
           <asp:Image ID="Avatar" runat="server" CssClass="w-25" />
           Nome: <asp:TextBox ID="txtNome" runat="server" CssClass="mb-2"></asp:TextBox>
           Cognome: <asp:TextBox ID="txtCognome" runat="server" CssClass="mb-2"></asp:TextBox>
           Indirizzo: <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="mb-2"></asp:TextBox>
           Telefono: <asp:TextBox ID="txtTelefono" runat="server" CssClass="mb-2"></asp:TextBox>
           Email: <asp:TextBox ID="txtEmail" runat="server" CssClass="mb-2"></asp:TextBox>
         <asp:Button ID="modificaButton" runat="server" Text="Salva Modifiche" CssClass="btn btn-warning" OnClick="modificaButton_Click" />
            
        </div>
</asp:Content>
