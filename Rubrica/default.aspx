<%@ Page Title="" Language="C#" MasterPageFile="~/Rubrica.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Rubrica._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server" ItemType="Rubrica.Persona">
            <ItemTemplate>
                <div class="col-4">
                    <div class="card" style="width: 18rem;">
                        <img src="Content/assets/<%# Item.Foto %>" class="card-img-top" alt="avatar">
                        <div class="card-body">
                        <h5 class="card-title"><%# Item.Cognome %> <%# Item.Nome %></h5>
                        <p class="card-text"> <%# Item.Indirizzo %></p>
                        <p class="card-text"> <%# Item.Telefono %></p>
                        <p class="card-text"> <%# Item.Email %></p>
                        <a href="detail.aspx?idPersona=<%# Item.Id %>" class="btn btn-primary">Dettaglio</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
