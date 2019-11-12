<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 39px">
    <form id="form1" runat="server">
    <div>
    <tr>
       <td>
            <asp:FileUpload ID="fupload" runat="server" />
       </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="upload" onclick="Button2_Click" />
        </td>
    </tr>
    </div>
    </form>
</body>
</html>
