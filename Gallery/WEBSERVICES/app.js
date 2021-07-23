let express = require('express');
let app = express();
let formidable = require ('formidable');

function addition (x,y){
    return x+y;
}

fs.readfile(logDateiPfad2, 'utf8',(err, logdaten)=> {console.log(logdaten)});

app.use(express.static(_dirname + "/public"));

//HTTP-GET
app.get('/addition', function(req,res){
    let zahl1 = req.query.x;
    let zahl2 = req.query.y;
    let ergebnis = addition(zahl1, zahl2);

    res.writeHead(200,{'Content-Type': 'application/json'});
    res.end('{"ergebnis": '+ ergebnis + '}');
    console.log('Handeled addition reqeuest for x=' + zahl1 + ' : y=' + zahl2);
    //in datei (webserver.log)speichern synchron
    fss.writeFile(logDateiPfad2,meldung, {flag})


});
app.listen(8888)