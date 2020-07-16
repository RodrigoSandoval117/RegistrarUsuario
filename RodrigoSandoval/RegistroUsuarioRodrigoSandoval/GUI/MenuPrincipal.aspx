<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/MasterDeMasters.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="RegistroUsuarioRodrigoSandoval.GUI.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        </div>
        <div class="row">
            <div class="col s12" style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="src/img/usuarioalta.png" OnClick="ImageButton1_Click" />
            </div>            
            <div class="col s12" style="text-align: center">
                <asp:Label ID="Label1" runat="server" Text="Registrar Usuarios"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col s12" style="text-align: center">
                <div class="col s12" style="text-align: center">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="src/img/dashboard.png" OnClick="ImageButton2_Click" />
                </div>
                <div class="col s12" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Dashboard"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
