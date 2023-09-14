<%@ Page Title="" Language="C#" MasterPageFile="~/Rubrica.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="Rubrica.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="card" style="width: 18rem;">
        <asp:Image ID="avatar" runat="server" Cssclass="card-img-top" alt="avatar" />
        <div class="card-body">
        <h5 class="card-title" id="headerName" runat="server"></h5>
        <p class="card-text" id="pIndirizzo" runat="server"></p>
        <p class="card-text" id="pTelefono" runat="server"></p>
        <p class="card-text" id="pEmail" runat="server"></p>
            <div>
                <asp:Button ID="modificaButton" runat="server" Text="Modifica" CssClass="btn btn-warning" OnClick="modificaButton_Click"/>
                <asp:Button ID="eliminaButton" runat="server" Text="Elimina" CssClass="btn btn-danger" OnClick="eliminaButton_Click"/>
             </div>
        </div>
     </div>
</asp:Content>
