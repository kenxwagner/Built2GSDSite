<!DOCTYPE html>
<html lang="en">
<header>
	<meta charset="UTF-8">
	<title>Welcome to Sam the Server</title>
	<script>
		var http = require('http');
		
		http.createServer(function(request, response) {
			response.writeHead(200, {'Content-Type': 'text/plain'}
			response.write('Hello Node JS Server Response');
			response.end();
		}).listen(7000);
	</script>
	</header>
	<body>
	Hello you node type person or thing. <br>
	This is what you call a static page
	<iframe src="https://google.com" frameborder="0">
	</iframe>
	</body>
	</html>