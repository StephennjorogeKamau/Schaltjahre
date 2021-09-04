interface Human{
   firstName : string;
   lastName : string;
   name : Function;
   isLate?(time: Date): Function;
}

class Person{
    firstname= "";
    lastname = "";

    constructor (firstName,lastName){
        this.firstname = firstname;
        this.lastname = lastname;
    }
    name(){
        return '$(this.firstname) $(this.lastname)';
    }
    whoAreYou(){
        return 'Hi i´m ${this.name()}';
    }
}
    class student extends Person {
        course;
        constructor(firstName, lastName, course){
            super (firstName, lastName);
            this.course = course;
        }

        whoAreYou(){

            return '${super.whoAreyou()} and i´m studying ${this.course}';
        }
        //test machen dass ich an person griefen kann
       // test()
}

let schuler = new student ("Stephen" ,"Njoroge","FIU20");
console.log(schuler.whoAreYou());