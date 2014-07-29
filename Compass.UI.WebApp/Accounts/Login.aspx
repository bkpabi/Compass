<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Compass.UI.WebApp.Accounts.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | Compass</title>
    <link href="../Themes/CompassSite.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:40px;"></div>
    <div id="shellTD" class="centerParent" style="height:500px;">
            <div id="shellTBL" class="center" style="width:935px; margin-left:auto; margin-right:auto; text-align:left;">
                <div id="shellBrand" style="width:475px; float:left; background-color:#0072C6;">
                    <img src="../Images/LoginPageBrand.png" />
                    <div style="height:80px;">&nbsp;<span style="color:#fff; font-size:25px; padding-top:15px; font-weight:600;">ROD Config - Issue Management</span></div>
                </div>
                <div id="shellSignIn" style="width: 420px; position: relative; float:left; line-height:142%;">
                    <div style="height:40px;"></div>
                    <div id="signInheader" style="width:190px; height:50px; margin-left:100px;"><span style="color:#0072C6; font-size:30px; font-size-adjust:0.58; padding-top:50px;">Compass</span>&nbsp;&nbsp;<span style="font-size:smaller; font-stretch:extra-expanded; color:#808080;">1.0</span></div>
                    <div style="height:30px;"></div>
                    <div id="signInTable" style="margin-left:100px;">
                        <asp:TextBox ID="userName" runat="server" style="width:300px; padding-left:5px; height:30px; border:1px solid #BABABA;"></asp:TextBox>
                        <asp:TextBox ID="password" TextMode="Password" runat="server" style="width:300px; padding-left:5px; height:30px; border:1px solid #BABABA; margin-top:15px;"></asp:TextBox><br /><br />
                        <asp:CheckBox ID="remember" runat="server" style="margin-top:15px; font-size:92%;" Text="Remeber Me" />
                        <br /><br />
                        <asp:Button ID="signin" runat="server" style="color:#FFF; font-weight:400; font-stretch:expanded; background-color:#1E82CC; margin-top:20px; height:30px; width:78px;border:1px solid #fff;" Text="Sign In" OnClick="signin_Click" />
                        <br /><br /><br /><br />
                        <span style="padding-top:30px; color:#0072C6; font-size:12px;">Forgot Password? Trouble Logging in?</span>
                    </div>
                </div>
            </div>
        </div>
    <div id="footer-container">
        <div id="footer">
            <div style="margin-top:15px; width:935px; margin:auto; height:60px; vertical-align:bottom;">
                <div style="color:#737373; font-size:15px; padding-top:15px; font-weight:500;">Positiveedge Technology</div>
                <div style="font-size:11px; padding-top:20px; color:#0072C6; float:right; margin-left:15px;">Term of Use</div>
                <div style="font-size:11px; padding-top:20px; color:#0072C6;  float:right;">Contact us</div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
