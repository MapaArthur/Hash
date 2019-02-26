<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TF_WebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Models/StylePageLogin.css" rel="stylesheet" " type="text/css" />
</head>
<body>
    <form id="form1" runat="server">       
        <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click"/> 
        <asp:TextBox ID="txt_userPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txt_userName" runat="server"></asp:TextBox>
        <asp:Image ID="img_login" runat="server" ImageUrl="~/Icons/login.png" />
        <asp:Image ID="img_user" runat="server" ImageUrl="~/Icons/user.png" />
        <asp:Image ID="img_password" runat="server" ImageUrl="~/Icons/keyPassword.png" />
        <asp:Label ID="lbl_CredencialIncorreta" runat="server" Text="Usuário ou senha incorretos" Visible="False"></asp:Label>
    </form>
</body>
</html>
