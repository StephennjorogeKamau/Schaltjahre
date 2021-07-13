//console.log("Hallo Welt");
//let ergbnis = 10 + 15;
//console.log(ergebnis);

function requestHandling(req, res){
    res.writeHead(200,{'Content-Type': 'text/plain'});
    res.write("Hallo User, Willkommen");
    res.end();
    console.log("Handled request")
}

let port = 8888;
let httpServer = require('http');
httpServer.createServer(requestHandling).listen(port, 'localhost');
console.log('sever is running at http://localhost:' + port + "/");


