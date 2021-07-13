let element =document.getElementById("0815");
       element.innerHTML="Hallo Welt Tomorrow";
       let IdElemente = document.getElementsByTagName("td");
       console.log(IdElemente);
       let Textbox = document.getElementsByName("Vorname");
       Textbox.values = "vorname eintragen";

       let button = document.getElementById("btn");
       button.addEventListener("click", welcome, false);

       //document.getElementById("btn");
       

       function welcome(){
           let vorname = document.getElementById("txbVorname").value;
           alert("Willkommen " + vorname + "!");
           
       }

       function checkName(){
           let nachname = document.getElementById("txbNachname").values;
           if (nachname == "")document.getElementById("txbNachname").setAttribute("style","background-color: red");
           else document.getElementById("txbNachname").setAttribute("style", "background-color: green");
       }

