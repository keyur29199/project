<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3> Your Birthday:</h3>
     
            <asp:Calendar ID="Calendar1" runat="server"  SelectionMode="DayWeek" 
            onselectionchanged="Calendar1_SelectionChanged">
            </asp:Calendar>
        
         
   
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
   </div> 
    </form>
</body>
</html>
