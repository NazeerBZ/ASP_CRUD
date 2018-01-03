<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WPL.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
   
    <style type="text/css">

       
        #container{

            width: 250px;
            margin: 0px auto;
            margin-top: 100px;
        }

        h1{

            text-align: center;
        }

        #login{

            margin-left: 81px;
            padding: 5px 15px 5px 15px;
            background-color: goldenrod;
            border: none;
        }

        #mylabel{

           color: lightcoral;
           font-family: fantasy;
        }

        #myLabel2{

           color: lightcoral;
           font-family: fantasy;
        }


         #user_name {

            width: 245px;
            padding: 10px 0px 10px 0px;
        }

        #pass {

            width: 245px;
            padding: 10px 0px 10px 0px;
        }

        #LinkButton1{

            margin-left: 13px;
        }

    </style>
    
</head>
<body style="height: 81px">
    <form id="form1" runat="server">

    <div id="container">
        
        <h1>Login In</h1>

        <asp:Label ID="incorrect" runat="server" ForeColor="Red" Visible="False"></asp:Label>

        <br />
       
        <asp:Label ID="mylabel" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="user_name" name="username" runat="server"></asp:TextBox>
        <br /><br />
        
        <asp:Label ID="myLabel2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="pass" name="password" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />

        <asp:Button ID="login" runat="server" Text="Log In" OnClick="login_Click1" />
        <br /><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Want To Make Account? Sign Up</asp:LinkButton>
        

    </div>
    </form>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Register]"></asp:SqlDataSource>


</body>
</html>
