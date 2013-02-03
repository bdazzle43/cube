<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<form enctype="multipart/form-data" action="${pageContext.request.contextPath}/upload.do" method="post">
	<input type="file" name="file" value="浏览"/>
	<input type="submit" value="提交"/>
</form>
</body>
</html>