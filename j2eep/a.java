import java.sql.*;

class a
{
	public static void main(String s[])
	{
		Connection con;
		Statement st;
		ResultSet rs;
	
		try
		{
		Class.forName("com.mysql.jdbc.Driver");
		con=DriverManager.getConnection("jdbc:mysql://localhost:3306/keyur","root","");
		st=con.createStatement();
		rs=st.executeQuery("select * from stud");
		
		while(rs.next())
		{
			System.out.println("rollno."+rs.getInt(1));
			System.out.println("studentname."+rs.getString(2));
			System.out.println("Stream."+rs.getString(3));
			System.out.println("fees"+rs.getFloat(4));
		}
		rs.close();
		st.close();
		con.close();
		
		}
		catch(SQLException ex)
		{
		System.out.println(ex.getMessage());
		}
		catch(ClassNotFoundException ex)
		{
		System.out.println(ex.getMessage());
		}
	}
}