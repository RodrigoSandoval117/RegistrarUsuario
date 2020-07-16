<%@ Page Title="Inicio de Sesión" Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="RegistroUsuarioRodrigoSandoval.GUI.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="src/css/materialize.min.css" rel="stylesheet" />
     <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/icon?family=Material+Icons"/>
    <script src="src/js/jquery-2.1.1.min.js"></script>
    <script src="src/js/materialize.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="row""></div>
                <div class="row""></div>
                <div class="row""></div>
                <div class="row""></div>
                <div class="col s4 m4 l4"></div>
                <div class="col s4 m4 l4">
                    <div class="card blue darken-1">
                        <div class="card-content white-text">
                            <span class="card-title">Inicio de sesión</span>
                            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtUsuario" CssClass="validate" runat="server"></asp:TextBox>                                
                            </div>
                            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                            <div class="input-field">
                                <asp:TextBox ID="txtContrasenia" type="password" CssClass="validate" runat="server"></asp:TextBox>                                
                            </div>
                        </div>
                        <div class="card-action">
                           <asp:Button OnClick="btnIngresar_Click"  ID="btnIngresar" CssClass="blue btn waves-effect waves-light" runat="server" Text="Ingresar" />
                        </div>
                    </div>
                </div>
                <div class="col s4 m4 l4"></div>
            </div>
        </div>
    </form>
</body>
</html>