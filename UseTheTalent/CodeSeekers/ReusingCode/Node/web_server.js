var http =  require("http");
var server = http.createServer(function(request, response) {
	response.writeHead(200, {"Content-Type": "text/html"});
	response.write("<!DOCTYPE html>");
	response.write("<html>");
	response.write("<head>");
	response.write("<title>Welcome to the Page</title>");
	response.write("</head>");
	response.write("<body>");
	response.write("Welcome to the World!");
	response.write("</body>");
	response.write("</html>");
	response.end();	
});

server.listen(80);
console.log("Server is listening... be afraid. Be very afraid!");