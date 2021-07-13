var meineVariable = "Hallo";    //Zeichenfolge
meineVariable = 10;             //Zahlen, Number
meineVariable = 10.5;
meineVariable = true;           //boolean

console.log("Ausgabe: ")
console.log(meineVariable);

console.log("\nOperation:");
console.log(10.5 + 10);             //20.5
console.log("Hallo " + 10);         //Hallo10
console.log("10 " + 10);            //1010
console.log("10 " - 10);            //0
console.log("10a " - 10);           //NaN Not a Number


var zahl = "slkasdfkj" - 56545;
console.log(zahl);
zahl = 1234;
console.log(isNaN(zahl));

var float = parseInt("10.5");
console.log(float);

var int = parseInt("2.6");
console.log(int);

console.log(Number("2.6"));

let Zeichenfolge1 = "Meine Zeichenfolge";
let Zeichenfolge2 = "Meine Zeichenfolge";

let Zeichenfolge3 = "Hallo 'JavaScript'!";
let Zeichenfolge4 = 'Hallo "JavaScript"!';

let Zeichenfolge5 = "'Hallo' \"JavaScript\"!";

console.log(typeof('Hallo'));
console.log(typeof(10.5));
console.log(typeof(true));

//Boolean
console.log('Apfel' != 'Birne');
console.log(10 > 9);
console.log(10 < 9);
console.log(10 == 9);

console.log(10 > 9 && 3 < 6);
console.log(10 > 9 || 3 < 6);

//Functions

let myDeleget = add;
console.log(myDeleget(1,2));

function add(x, y){
    let result = x + y;
    x = 1;
    y = 2;
    return result;
}

let a = 5;
let b = 10;
let c = add(a, b);

console.log("Ergebnis: " + c);
console.log("a: " + a);
console.log("b: " + b);

//Keine Hoisting "Error "
//console.log(meinUnbenannteFuktion(10,8));
let meinUnbenannteFuktion = function (x, y){
    return x - y;
}
console.log(meinUnbenannteFuktion(10,8));


let promptResult = prompt("zur Info ... !!! Bitte Name eingaben!");
console.log(promptResult);

let confirmResult = confirm("Bestätigen?");
console.log(confirmResult);

if(confirmResult) console.log ("Bestätigt!");
else console.log("Nicht Bestätigt!");

promptResult = promptResult || "Michael"; // Wenn promtResult null

switch (promptResult){
    case 'Michael' :
        alert ("Hallo Michael");
        break;
        default:
            alert("Hallo User");
            break;
}



console.log(a == b);
console.log(a == "5");
console.log(a === "5");
console.log(a <<= 3);
console.log(a >>= 3);


for(let i = 0; i< 10; i++){
    console.log(i);
}

let x = 10;
while(x > 0){
    x--;
    console.log(x);
}

let confirmed = false;
do{
    confirmed = confirm("Wollen sie Wirklich?");
}while (!confirmed)


try{
    undefinedFuntion();
    alert("made it!");
}catch(ex){
    alert("Fehler: " + ex.message);
}finally {
    alert ("Finaly Block");
}


let meinArray = new Array();
meinArray [0] = 'Bikes';
meinArray [1] = 'Rollers';
meinArray [2] = 10;
 
let meinArray2 = new Array('Salami', 'Schinken', 'Käse');
let meinArray3 = ['Pepperoni', 'Zwibel', 'Olive'];

for(i = 0; i < meinArray.length; i++) console.log (meinArray[i]);

let ZwibelIndex = meinArray3.indexOf('Zwibel');         //1
//let ZwibelIndex = meinArray3.lastIndexOf('Zwibel');     //3

meinArray3.push('Sardien');
console.log(meinArray3.pop());

meinArray3.reverse();
console.log(meinArray3);

meinArray3.sort();
console.log(meinArray3);

meinArray3.reverse();
console.log(meinArray3);

console.log(meinArray3.shift()); //entfernt Element 0 aus dem Array und lifert Array 















