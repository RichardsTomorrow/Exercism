export class Triangle {
  constructor(...sides) {
    this.sides = sides.sort((a,b)=> a-b); // sorts small to large
  }
  
  kind() {
    const [x,y,z] = this.sides; //assign variables
    if(x === 0){throw "A triangle's sides must have a length greater than 0.";} // tests is smallest side is 0
    else if (x < 0){throw "A triangle's side can't be negative.";} // tests if smallest side is negative
    else if(!(x + y > z)){throw "This triangle violates triangle equality.";} //tests if triangle meets equality
    else if((x + y === z)){throw "This triangle is a degenerate.";}// tests if the triangle looks like a straight line
    else if (x === y && y === z){return 'equilateral';}// matches all side
    else if (x === y || y === z){return 'isosceles';}// matches one set of sides
    else{return 'scalene';} // all others are scalene
  }
}
