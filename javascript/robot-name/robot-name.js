// This is only a SKELETON file for the 'Robot Name' exercise. It's been
// provided as a convenience to get your started writing code faster.
let usedNames = {};

export class Robot { 
    constructor(){
        this.reset();// first time boot up is basically a reset
    }
    
    get name(){
        return this._name;
    }
    reset(){// gives the robot a new name
        this._name = nameGenerator();
    }
}

function nameGenerator() { // strings together the required number of each character and redoes it if it isnt unique
    let newName = '';
    do{
        newName = randomCap() + randomCap() + randomNum() + randomNum() + randomNum();
    } while(usedNames[newName]);
    usedNames[newName] = true;
    return newName;
}

function randomCap(){ //picks a random cap character
    return String.fromCharCode(Math.floor((Math.random()*26) + 65));
}

function randomNum(){// picks a random number
    return Math.floor((Math.random()*10));
}

Robot.releaseNames = () => usedNames = {}; //this is required by Exercism and it resets the usedNames list.
