﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label 
             ID="Label1" 
             runat="server"
             Text="This is a test Label"
             >
        </asp:Label>
        <br /><br />
        <asp:Button 
             ID="Button1" 
             runat="server" 
             ForeColor="Crimson"
             Text="Label Background LightGreen"
             OnClick="Button1_Click"
             Font-Bold="true"
             />
        <asp:Button 
             ID="Button2" 
             runat="server" 
             Font-Bold="true"
             ForeColor="Crimson"
             Text="Label Background SkyBlue"
             OnClick="Button2_Click"
             />
    </div>
    </form>
</body>
</html>
