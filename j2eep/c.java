import java.sql.*;

class c
{
	public static void main(String s[])
	{
		Connection con;
		PreparedStatement pst;
		try
		{
			Class.forName("com.mysql.jdbc.Driver");
				con=DriverManager.getConnection("jdbc:mysql://localhost:3306/keyur","root","");
			pst=con.prepareStatement("insert into emp values(?,?,?)");
			pst.setInt(1,101);
			pst.setString(2,"james");
			pst.setDouble(3,30000.50);
			pst.executeUpdate();
			System.out.println("record inserted");
			con.close();
		}
		catch(SQLException e)
		{
			System.out.println(e.getMessage());
		}
		catch(ClassNotFoundException e)
		{
			System.out.println("class not found:"+e.getMessage());
		}
	}
}	
			
			
			
			
			
			
			
			
			