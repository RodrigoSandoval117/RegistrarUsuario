<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/MasterDeMasters.Master" AutoEventWireup="true" CodeBehind="AltaUsuario.aspx.cs" Inherits="RegistroUsuarioRodrigoSandoval.GUI.AltaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">
                <div class="row""></div>
                <div class="row""></div>
                <div class="row""></div>
                <div class="col s2 m2 l2"></div>
                <div class="col s8 m8 l8">
                    <div class="card blue darken-1">
                        <div class="card-content white-text">
                            <span class="card-title">Registro de usuarios</span>
                            <asp:Label ID="Label1" runat="server" Text="Nombre*"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtUsuario" CssClass="validate" runat="server" MaxLength="50"></asp:TextBox>
                                <asp:Label ID="obliUsuario" Visible ="false" runat="server" Text="*Campo obligatorio*"></asp:Label>
                            </div>
                            <asp:Label ID="Label2" runat="server" Text="Correo Electrónico*"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtCorreo" CssClass="validate" runat="server" MaxLength="50"></asp:TextBox>
                                <asp:Label ID="obliEmail" Visible ="false" runat="server" Text="*Campo obligatorio*"></asp:Label>
                            </div>
                            <asp:Label ID="Label3" runat="server" Text="Estado*"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtEstado" CssClass="validate" runat="server" MaxLength="50"></asp:TextBox>    
                                <asp:Label ID="obliEstado" Visible ="false" runat="server" Text="*Campo obligatorio*"></asp:Label>                            
                            </div>
                            <asp:Label ID="Label4" runat="server" Text="Edad"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtEdad" CssClass="validate" runat="server" MaxLength="3"></asp:TextBox>                                
                            </div>
                            <asp:Label ID="Label5" runat="server" Text="Teléfono"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtTelefono" CssClass="validate" runat="server" MaxLength="13"></asp:TextBox>                                
                            </div>
                            <div class="input-field">
                                <input id="chkAcepto" runat="server" type="checkbox" class="filled-in" style="opacity: unset; left: unset; position: unset; width: 20px; height: 20px;" />
                                <asp:Label ID="Label7" runat="server" Text="Acepto el ''Aviso de privacidad''"></asp:Label>
                            </div>
                            <asp:Label ID="obliCheck" Visible ="false" runat="server" Text="*Tiene que aceptar la privacidad*"></asp:Label>
                        <div class="card-action">
                           <asp:Button OnClick="btnIngresar_Click"  ID="btnIngresar" CssClass="blue btn waves-effect waves-light" runat="server" Text="Agregar"  />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
