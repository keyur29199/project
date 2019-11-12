import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class Hello extends HttpServlet
{
	public void doget(HttpServletRequest req,HttpServletResponse res) throws servletException,IOException
	{
		res,setContentType("text/html");
		PrintWriter out=res.getWriter();
		out.println("<html>");
		System.out.println("<head> Hello World </head>");
		System.out.println("<body>");
		System.out.println("<big> first servlet </big>");
		System.out.println("</body> </html>");
	}
}