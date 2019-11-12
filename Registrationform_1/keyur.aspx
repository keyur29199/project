<%@ Page Language="C#" AutoEventWireup="true" CodeFile="keyur.aspx.cs" Inherits="keyur" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head id="Head1" runat="server">
    <title>REGISTRATION FORM</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
              <table class="auto-style1" align="center">  
    <tr>  
    <td>  
    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="username" runat="server" required="true"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="EmailID" runat="server"></asp:TextBox></td>  
    </tr>  
    
    <tr>  
    <td>  
    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>  
    <td>  
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />  
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" /></td>  
    </tr>  
    
     <tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="Adress"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>  
    </tr>  
   
    <tr>  
    <td>  
    <asp:Label ID="Label3" runat="server" Text="ContactNo:"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="TextBox2" runat="server" MaxLength="10"></asp:TextBox></td>  
    </tr>  
    
    <tr>
    <td>
        <asp:Label ID="Label5" runat="server" Text="State"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="ddstate" runat="server"  
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem>Gujarat</asp:ListItem>
            <asp:ListItem>Maharastra</asp:ListItem>
            <asp:ListItem>Rajasthan</asp:ListItem>
        </asp:DropDownList> 

    </td>
    </tr>  

    <tr>
    <td>
        <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="ddcity" runat="server" AutoPostBack="True">
            <asp:ListItem>rajkot</asp:ListItem>
            <asp:ListItem>ahemdabad</asp:ListItem>
            <asp:ListItem>surat</asp:ListItem>
            <asp:ListItem>nagpur</asp:ListItem>
            <asp:ListItem>mumbai</asp:ListItem>
            <asp:ListItem>pune</asp:ListItem>
            <asp:ListItem>jodhpur</asp:ListItem>
            <asp:ListItem>jaypur</asp:ListItem>
            <asp:ListItem>udaypur</asp:ListItem>
        </asp:DropDownList> 

    </td>
    </tr>  

    <tr>
    <td>
        <asp:Label ID="Label8" runat="server" Text="Hobby:"></asp:Label>
        </td>
    <td>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="writting" />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Singing" />
                                <asp:CheckBox ID="CheckBox4" runat="server" Text="Dancing" />
    </td>
</tr>

 <tr>
    <td>
        <asp:Label ID="Label9" runat="server" Text="Stream"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server"  
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem>BCA</asp:ListItem>
            <asp:ListItem>BBA</asp:ListItem>
            <asp:ListItem>B.COM</asp:ListItem>
        </asp:DropDownList> 

    </td>
    </tr> 
    
    <tr>  
        <td>  
        <asp:Button ID="Button1" runat="server" Text="Submit" value="submit" />
        </td>
    </tr>  

    <tr>
       <td>
            <asp:FileUpload ID="fupload" runat="server" />
       </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="upload" onclick="Button2_Click" />
        </td>
    </tr>

    <td colspan = "2">

        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    </td>


    </table>
    </div>
    </form>
</body>
</html>
