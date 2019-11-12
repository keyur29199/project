<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
            <table  align="center"> 
            <tr>
                <th>REGISTRATION FORM</th> 
            </tr>
            

            <tr>
           <td>
               <asp:Label ID="Labelnm" runat="server" Text="User Name :"></asp:Label>
           </td>  
           <td>
            <asp:TextBox ID="TextBoxnm" runat="server" required="true" 
                   ontextchanged="TextBoxnm_TextChanged"></asp:TextBox>
           </td>  
          </tr>
            
           <tr>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Gender :"></asp:Label>
           </td>  
           <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="16px" 
                   RepeatDirection="Horizontal" Width="140px">
               <asp:ListItem>Male</asp:ListItem>
               <asp:ListItem>Female</asp:ListItem>
               </asp:RadioButtonList> 
           </td>  
          </tr>
            
           <tr>
           <td>
               <asp:Label ID="Labeladd" runat="server" Text="Address :"></asp:Label>
           </td>  
           <td>
            <asp:TextBox ID="TextBoxadd" runat="server"></asp:TextBox>
           </td>  
          </tr>
            
             <tr>
           <td>
               <asp:Label ID="Labelemail" runat="server" Text="E-mail :"></asp:Label>
           </td>  
           <td>
            <asp:TextBox ID="TextBoxemail" runat="server"></asp:TextBox>
           </td>  
          </tr>

           <tr>
           <td>
               <asp:Label ID="Labelcon" runat="server" Text="Conatact :"></asp:Label>
           </td>  
           <td>
            <asp:TextBox ID="TextBoxcon" runat="server"></asp:TextBox>
           </td>  
          </tr>

             <tr>
           <td>
               <asp:Label ID="Label2" runat="server" Text="State :"></asp:Label>
           </td>  
           <td>
               <asp:DropDownList ID="ddstate" runat="server" AutoPostBack="true"
                   onselectedindexchanged="ddstate_SelectedIndexChanged">
                   <asp:ListItem>Gujarat</asp:ListItem>
                   <asp:ListItem>Rajashthan</asp:ListItem>
                   <asp:ListItem>Maharashtra</asp:ListItem>
               </asp:DropDownList>

           </td>  
          </tr>
    
                    
            <tr>
           <td>
               <asp:Label ID="Label3" runat="server" Text="City :" ></asp:Label>
           </td>  
           <td>
               <asp:DropDownList ID="ddcity" runat="server">
               </asp:DropDownList>

           </td>  
          </tr>
            
            <tr>
           <td>
               <asp:Label ID="Label4" runat="server" Text="Hobby :"></asp:Label>
           </td>  
           <td>
               <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading"/>
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Writting"/>
                 <asp:CheckBox ID="CheckBox3" runat="server" Text="Singing"/>
                  <asp:CheckBox ID="CheckBox4" runat="server" Text="Dancing"/>
                  <asp:CheckBox ID="CheckBox5" runat="server" Text="Programming"/>
           </td>  
          </tr>

            <tr>
           <td>
              <asp:Button ID="btnsub" runat="server" Text="submit" onclick="btnsub_Click" />
          </td>
          </tr>


             </table>

    </div>
    </form>
</body>
</html>
