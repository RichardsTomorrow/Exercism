//
// This is only a SKELETON file for the 'Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
  constructor(x, y, z) {
    this.x = x;
    this.y = y;
    this.z = z;
  }

  kind() {
    if(this.x === 0 || this.y === 0 || this.z === 0){throw "A triangle's sides must have a length greater than 0.";}
    else if (this.x < 0 || this.y < 0 || this.z < 0){throw "A triangle's side can't be negative.";}
    else if(!(this.x + this.y > this.z) ||!(this.y + this.z > this.x) ||!(this.z + this.x > this.y) ){
      throw "This triangle violates triangle equality.";}
    else if((this.x + this.y === this.z) ||(this.y + this.z === this.x) ||(this.z + this.x === this.y) ){
      throw "This triangle is a degenerate.";}
    else if (this.x === this.y && this.y === this.z){return 'equilateral';}
    else if (this.x === this.y || this.x === this.z || this.y === this.z){return 'isosceles';}
    else{return 'scalene';}
  }
}
