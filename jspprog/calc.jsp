<html>
<% try { %>
<% = Integer.ParseInt(request.getParameter("t1")); + Integer.ParseInt(request.getParameter("t2")); %>
<% } catch (NumberFormatException n2) { % >
<% out.println(n2) ; } %>
</html>
