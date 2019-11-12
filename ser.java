imoprt java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
//program-12
public class demo extends Httpservlet
{
	public void doGet(HttpServletRequest req,HttpServletResponse res)throws ServletException,IOException
	{
		res.setContentType("text/html");
		PrintWriter out=res.getWrite();
		out.prinln("<html>");
		out.prinln("<h3>My Request</h3>");
		out.prinln("<table borde=2><tr><td>");
		out.prinln("method:");
		out.prinln("</td></td>");
		out.prinln(req.getMethod());
		out.prinln("</td></tr><tr><td>");
		out.prinln("Request URL:");
		out.prinln("</td></td>");
		out.prinln(req.getRequestURL());
		out.prinln("</td></tr><tr><td>");
		out.prinln("Protocol:");
		out.prinln("</td></td>");
		out.prinln(req.getProtocol());
		out.prinln("</td></tr><tr><td>");
		out.prinln("</table>");
		out.prinln("</html>");
		getServletConfig().getSevletContext().getRequestDispatcher("mypath/helloincluded").include(req,res);
	}
}	


import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
//program-12 2nd Servlet
public class helloincluded extends Httpservlet
{
	public void doGet(HttpServletRequest req,HttpServletResponse res)throws ServletException,IOException
	{
		res.setContentType("text/html");
		PrintWriter out=res.getWrite();
		out.println("<html>");
		out.println("<h1>hello !!</h1>");
		out.println("<h3>Servlet Collaboration</h3>");
		out.println("</html>");
	}
}