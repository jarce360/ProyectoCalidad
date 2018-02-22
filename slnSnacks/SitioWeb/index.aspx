
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="slnSnacks.SitioWeb.index" %>

<!DOCTYPE html>
<html lang="es">

<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>Iniciar Session</title>
    <link href="../css/login.css" rel="stylesheet" />
</head>

<body>
    
<div class="login">
	<h1>Iniciar sesión</h1>
     <form runat="server">
    	<asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
        <asp:TextBox ID="Contrasena" runat="server"></asp:TextBox>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <asp:Button ID="validateUser" runat="server" Text="conectarse" CssClass="btn btn-primary btn-block btn-large" OnClick="validateUser_Click"/>
    </form>
</div>
</body>
</html>