let Vehicle = ( function (){
    function Vehicle (theYear, make, model){
        let year = theYear;
        this.make = make;
        this. model = model;
        this.getYear = function(){return year;}
    }
Vehicle.prototype.getinfo = function (){
    return "info " + this.getYear() + " " + this.make + " " + this.model;
}
return Vehicle;
})();
