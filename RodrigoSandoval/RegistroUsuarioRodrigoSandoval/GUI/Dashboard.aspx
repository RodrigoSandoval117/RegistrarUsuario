<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/MasterDeMasters.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="RegistroUsuarioRodrigoSandoval.GUI.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row""></div>
    <div class="row""></div>
    <div class="row""></div>
    <div class="container">
        <div class="row">
            <div class="col s6 m6 l6">
                <asp:Label ID="Label1" runat="server" Text="Usuarios registrados:"></asp:Label>
            </div>
            <div class="right-align col s6 m6 l6">
                <asp:Button OnClick="btnIngresar_Click" class="right-align" ID="btnIngresar" CssClass="blue btn waves-effect waves-light" runat="server" Text="Descargar información" />
            </div>
            <div class="col s1 m1 l1 center-align">
                <asp:Label ID="contador" runat="server" Text="0"></asp:Label>
            </div>
        </div>

        <div class="card-panel">
            <asp:GridView ID="gvProductos" runat="server" CellPadding="4" CssClass="lighten-5 responsive-table" GridLines="None"
                DataKeyNames="IDUsuario" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="FechaCreacion" HeaderText="Fecha de registro" />
                    <asp:BoundField DataField="IDUsuario" HeaderText="ID Usuario" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Email" HeaderText="Correo" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                    <asp:BoundField DataField="Edad" HeaderText="Edad" />
                    <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
