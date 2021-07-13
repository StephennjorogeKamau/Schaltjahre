$(document).ready(function(){
    $('#btnAdd').on('click', RemoteAddition);
});

function RemoteAddition(){
    console.log("btn clicked!");
    let x = document.getElementById('x').value;
    let y = document.getElementById('y').value;
    let query = "/addition?x="+x+"&y="+y;

    //XMLHttpRequest
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.open("Get",query, false); // method,url,async
    xmlhttp.send();

    let jsonobject = JSON.parse(xmlhttp.response);
    document.getElementById("result").innerHTML = jsonobject.ergebnis;

    function RemoteAdditionAsync(){
        console.log("btn clicked!");
        let x = document.getElementById('x').value;
        let y = document.getElementById('y').value;
        let query = "/addition?x="+x+"&y="+y;

        let xmlhttp = new XMLHttpRequest();


        //ReadyStates
        //0 - Uninitialized -> die open-Method wurde noch nicht aufgerufen 
        // 1- Loading -> die Send-Methode wurde noch nicht aufgerufen 
        // 2- Loaded -> die Send-Methode wurde aufgerufen 
        // 3- Interactive -> Der Content wird heruntergeladen
        xmlhttp.onreadystatechange = function(){
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200){
                let jsonobject = JSON.parse(xmlhttp.response);
                document.getElementById("result").innerHTML = jsonobject.ergebnis;
            }
            console.log("ReadyState: " + xmlhttp.readyState);
        }
        // 4- Completed 

        xmlhttp.open("GET", query, true);
        xmlhttp.send();
    }

}

//AJAX über jQuery
function RemoteAdditionJQuery(){
    console.log("jQuery");
    let x = $('#x').val();
    let y = $('#y').val();
    let request = {"x": x,"y": y}

    $.getJSON('/addition', request, function(response){
        $('#result')
    }
}