//
// This is only a SKELETON file for the 'Difference of Squares' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Squares {
  constructor(num) {
    this.max = num;
  }

  get sumOfSquares() {
    let _sumOfSquares = 0;
    for(let i = 1; i <= this.max; i++){
      _sumOfSquares += i * i;
    }
    return _sumOfSquares;
  }

  get squareOfSum() {
    let _squareOfSum = 0;
    for(let i =  1; i <= this.max; i++){
      _squareOfSum += i;
    }
    return _squareOfSum *_squareOfSum;
  }

  get difference() {
    let answer = this.squareOfSum - this.sumOfSquares
    return answer;
  }
}
