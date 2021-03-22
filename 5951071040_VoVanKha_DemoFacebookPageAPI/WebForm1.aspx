<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5951071040_VoVanKha_DemoFacebookPageAPI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo Facebook Page API</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="355px">3 bài đăng gần nhất trên trang UTC2HCMC</asp:TextBox>
        </p>
        <div style="margin-bottom: 20px">      
            <asp:Label ID="lbContent" runat="server"></asp:Label>
        </div>
        
    </form>
</body>
</html>
