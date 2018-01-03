<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Working.aspx.cs" Inherits="Testing.Working" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email</title>
    

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
    

</head>
<body>
    <form id="form1" runat="server">
    <div>
             
        
                   
        <table class="auto-style1">
            
                <asp:Label ID="Label1" runat="server" Text="Electronic Mail"></asp:Label>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="To"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Message"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="188px" Width="412px"></asp:TextBox></td>
            </tr>

        </table>
             
            <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
                   
    </div>
    </form>
</body>
</html>
