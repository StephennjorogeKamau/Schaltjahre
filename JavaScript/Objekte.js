let car1 = {
    year: 2014,
    make: 'Renault',
    model: 'megane mk3',
    getInfo: function() {
        return 'Vehicle: ' + this.year + '' + this.make + '' + this.model;
    }
};

let car2 = {
    year: 2021,
    make: 'Hyundai',
    model: 'Tucson',
    getInfo: function() {
        return 'Vehicle: ' + this.year + '' + this.make + '' + this.model;
    }
};

function getVehicle(theyear, theMake, theModel){
    let Vehicle = new Object();
    Vehicle.year = theyear;
    Vehicle.make = theMake;
    Vehicle.model = theModel;
    Vehicle.getInfo = function(){
        return 'Vehicle: ' + this.year + '' + this.make + '' + this.model;
    };
    return Vehicle;
}
//console
let car3 = getVehicle(2018,'BMW','X3');
console.log(car3.getInfo());

car3.year = 2016
console.log(car3.getInfo());

//Erstellen einer klasse

function Vehicle(theyear, theMake, theModel){
    year = theyear;
    make = theMake;
    model = theModel;
    this.getInfo = function () {
        return 'Vehicle: ' + year + '' + make + '' + model;
    };
}

let car4 = new Vehicle(2021, "Seat", "Ibiza")
console.log(car4.getInfo());
console.log(car4);

car4.year = 1904;
console.log(car4);