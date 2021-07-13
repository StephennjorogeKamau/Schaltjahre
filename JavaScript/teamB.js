var teamB = teamB || {}

let Vehicle = (function(){
    function Vehicle (theYear){
        let year = theYear;
        this.getYear = function () {return this.getYear()};
    }
    Vehicle.prototype.getInfo = function (){return this.getYear()};
    return Vehicle;
})();

let car1 = new teamB.Vehicle(1000);
console.log(car1.getInfo());