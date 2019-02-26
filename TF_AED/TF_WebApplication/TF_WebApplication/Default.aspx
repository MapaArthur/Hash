<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TF_WebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Página Default</p>
            </div>
        <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <br />
        <asp:Button ID="btn_sair" runat="server" Text="Sair" OnClick="btn_sair_Click" />
    </form>
</body>
</html>
