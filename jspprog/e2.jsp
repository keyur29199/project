<% @page errorpage="e3.jsp" %>
<html>
	<% int fno,sno;
	
	fno= Integer.ParseInt(request.getParameter("fno"));
	sno= Integer.ParseInt(request.getParameter("sno"));
	int div=fno/sno; %>
	
	<p> Division is: <% =div %> </p>
	<p> <a href="e1.html"> back </p>
	</html>