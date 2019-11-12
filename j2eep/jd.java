import java.sql.*;

class jd
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
			rs=st.executeQuery("select * from emp");
			while(rs.next())
			{
				System.out.println("EMPNO."+rs.getInt(1));
				System.out.println("EMPNAME"+rs.getString(2));
				System.out.println("EMPSAL"+rs.getDouble(3));
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
			System.out.println("class not found"+ex.getMessage());
		}
	}
}	