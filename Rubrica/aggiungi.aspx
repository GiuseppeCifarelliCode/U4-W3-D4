<%@ Page Title="" Language="C#" MasterPageFile="~/Rubrica.Master" AutoEventWireup="true" CodeBehind="aggiungi.aspx.cs" Inherits="Rubrica.aggiungi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="text-center">Aggiungi un nuovo Contatto in Rubrica!</h3>
    <div class="d-flex flex-column align-items-center">
    <div class="my-2">
    <label for="txtNome">Nome:</label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </div>
    <div class="my-2">
    <label for="txtCognome">Cognome:</label>
    <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
        </div>
    <div class="my-2">
    <label for="txtIndirizzo">Indirizzo:</label>
    <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
        </div>
    <div class="my-2">
    <label for="txtTelefono">Telefono:</label>
    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </div>
    <div class="my-2">
    <label for="txtEmail">Email:</label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
    <div class="my-2">
    <label for="fileFoto">Seleziona una Foto Profilo:</label>
    <asp:FileUpload ID="fileFoto" runat="server" />
        </div>
    <asp:Button ID="aggiungiContatto" runat="server" Text="Salva" CssClass="btn btn-primary" OnClick="aggiungiContatto_Click"/>
        </div>
</asp:Content>
