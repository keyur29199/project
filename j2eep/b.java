import java.sql.*;

class b
{
	public static void main(String a[])
	{
		Connection con;
		Statement st;
		try
		{
			Class.forName("com.mysql.jdbc.Driver");
			con=DriverManager.getConnection("jdbc:mysql://localhost:3306/keyur","root","");
			st=con.createStatement();
			st.executeUpdate("insert into stud values(101,'ABC','BCA',26000.00)");
			System.out.println("Record added...");
		}
		catch(SQLException e1)
		{
			System.out.println("sqlerror:"+e1.getMessage());
		}
		catch(ClassNotFoundException e2)
		{
			System.out.println("class not found"+e2.getMessage());		
		}
	}
}