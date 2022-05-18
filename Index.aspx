<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UnsaveWebsiteLogin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox type="text" ID="UsernameInput" name="" value="" placeholder="Username"  runat="server"/>
            <asp:TextBox type="text" ID="PasswordInput" name="Password" value="" placeholder="Password" runat="server"/>

            <asp:Button runat="server" Text="Login" OnClick="TryLogin" />
        </div>
    </form>
    <asp:Literal ID="LoginInfo" runat="server"/>
</body>
</html>
