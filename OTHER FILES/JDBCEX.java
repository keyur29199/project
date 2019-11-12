import java.sql.*;
class JDBCEX
{
Connection con;
Statement st;	
ResultSet rs;	
public JDBCEX() 
{
try{ Class.forName("com.mysql.jdbc.Driver");
con = DriverManager.getConnection("jdbc:mysql://localhost/test"); //There should be a database named as test in your phpmyadmin.
System.out.println("Connected Successfully");
st=con.createStatement(); 
rs=st.executeQuery("Select * from test1");	//There should be a table named as test1 in your database test1.
while(rs.next())
{
//There should be some records test1. To Check Output.
System.out.println("\n rollno : "+rs.getInt(1)+"\n name : "+rs.getString(2)+"\n address : "+rs.getString(3)+"\n emailid : "+rs.getString(4)+"\n");
}	
}
catch(Exception e){	
System.out.println(e);
}
}
public static void main(String args[]) 
{
JDBCEX t = new JDBCEX();
}
}
