<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WPL.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">

        #container2{

            width: 465px;
            margin: 0px auto;
            margin-top: 100px;
        }

        h1{

            text-align:center;
        }

        #label1_email{

           color: lightcoral;
           font-family: fantasy;
        }
        
        #label2_username{

           color: lightcoral;
           font-family: fantasy;
        }

        #label3_password{

           color: lightcoral;
           font-family: fantasy;
        }

        #label4_phone{

           color: lightcoral;
           font-family: fantasy;
        }

        #email_textbox{

           width: 250px;
           margin-left: 53px;
        }

        #usernaam_textbox{

           width: 250px;
           margin-left: 25px;
        }

        #password_textbox{

           width: 250px;
           margin-left: 29px;
        }

         #phone_textbox{

           width: 250px;
           margin-left: 32px;
        }

        #SignUp_Button{

            margin-left:170px;
        }

        span{

            color : red;
        }

        .auto-style1 {
            width: 464px;
        }

    </style>
    
    <script src="Script.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="container2" class="auto-style1">
    
        <h1>Sign Up</h1>
        <asp:Label ID="label1_email" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="email_textbox" name="email" runat="server" TextMode="Email" required="required" placeholder="Your_Email@xyz.com"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />

        <asp:Label ID="label2_username" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="usernaam_textbox" name="username" runat="server" required="required" placeholder="UserName with atleast 2 digits"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />

        <asp:Label ID="label3_password" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="password_textbox" name="password" runat="server" TextMode="Password" required="required" placeholder="Your Password"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />

        <asp:Label ID="label4_phone" runat="server" Text="Phone No:"></asp:Label>
        <asp:TextBox ID="phone_textbox" name="phone_no" runat="server" required="required"  placeholder="Your Number"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />

        <asp:Button ID="SignUp_Button" runat="server" Text="Sign Up" OnClientClick="return myfunct()" OnClick="SignUp_Button_Click" />

    </div>


    </form>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Register]"></asp:SqlDataSource>

</body>
</html>
