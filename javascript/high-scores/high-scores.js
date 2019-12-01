//
// This is only a SKELETON file for the 'High-Scores' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class HighScores {
  constructor(input) {
    this._scores = input;
  }

  get scores() {
    return this._scores;
  }

  get latest() {
    return this._scores[this._scores.length-1];
  }

  get personalBest() {
    const tops = this._scores.sort(function(a, b){return b - a});
    return tops[0];
  }

  get personalTopThree() {
    const tops = this._scores.sort(function(a, b){return b - a});
    return tops.splice(0,3);
  }
}
