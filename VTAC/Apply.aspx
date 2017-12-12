<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="FormTest.Apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <center><h1>VTAC Application</h1></center>
            <br />
            <br />
            <center><p>Please fill out the form  truthfully. Using illegitimate information will have harsh consequences.</p></center>
            &nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <p style="padding:0px 40.5em;">Name:<asp:TextBox ID="name" runat="server"></asp:TextBox>
            </p>
            <p style="padding:0px 40.5em;">Age:<asp:TextBox ID="age" runat="server"></asp:TextBox>
            </p>
            <p style="padding:0px 40.5em;">Do you have a working headset/headphones & microphone?<asp:RadioButtonList ID="miccheck" runat="server">
                <asp:ListItem style="padding:0px 40.5em;">Yes</asp:ListItem>
                <asp:ListItem style="padding:0px 40.5em;">No</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p style="padding:0px 40.5em;">Why are you interested in joining VTAC?<asp:TextBox ID="why" runat="server" Height="161px" Width="366px"></asp:TextBox>
            </p>
            <p style="padding:0px 40.5em;">If you were referred by a member of VTAC, enter their name here:<asp:TextBox ID="referrer" runat="server"></asp:TextBox>
            </p>
            <br />
            <center>
            <p style="padding:0px 40.5em;">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"  />
            </p>
            <p style="padding:0px 40.5em; height: 120px;">
                <asp:Label ForeColor="Green" ID="ConfText" runat="server" Text="  "></asp:Label>
                </p>
            </center>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
