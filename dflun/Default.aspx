<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    
    <tr>  
    <td>  
    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>  
    <td>  
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" 
            oncheckedchanged="RadioButton1_CheckedChanged" AutoPostBack="True" />  
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" 
            oncheckedchanged="RadioButton2_CheckedChanged" AutoPostBack="True" />
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

    </td>  
    </tr>


    
    <tr>
    <td>
        <asp:Label ID="Label8" runat="server" Text="Hobby:"></asp:Label>
        </td>
    <td>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading" AutoPostBack="True" 
            oncheckedchanged="CheckBox1_CheckedChanged" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="writting" 
            AutoPostBack="True" oncheckedchanged="CheckBox2_CheckedChanged" />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Singing" 
            AutoPostBack="True" oncheckedchanged="CheckBox3_CheckedChanged" />
                                <asp:CheckBox ID="CheckBox4" runat="server" 
            Text="Dancing" AutoPostBack="True" 
            oncheckedchanged="CheckBox4_CheckedChanged" />
                              
    </td>
</tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />  
        </td>
    </tr>
    <tr>
        <td>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </td>
   </tr>

</table>
    </div>
    </form>


</body>
</html>
