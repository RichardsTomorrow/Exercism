//
// This is only a SKELETON file for the 'Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
  constructor(side1, side2, side3) {
    this.side1 = side1;
    this.side2 = side2;
    this.side3 = side3;
  }

  kind() {
    if(this.side1 === 0 || this.side2 === 0 || this.side3 === 0){throw "A triangle's sides must have a length greater than 0.";}
    else if (this.side1 < 0 || this.side2 < 0 || this.side3 < 0){throw "A triangle's side can't be negative.";}
    else if(!(this.side1 + this.side2 > this.side3) ||!(this.side2 + this.side3 > this.side1) ||!(this.side3 + this.side1 > this.side2) ){
      throw "This triangle violates triangle equality.";}
    else if((this.side1 + this.side2 === this.side3) ||(this.side2 + this.side3 === this.side1) ||(this.side3 + this.side1 === this.side2) ){
      throw "This triangle is a degenerate.";}
    else if (this.side1 === this.side2 && this.side2 === this.side3){return 'equilateral';}
    else if (this.side1 === this.side2 || this.side1 === this.side3 || this.side2 === this.side3){return 'isosceles';}
    else{return 'scalene';}
  }
}
