//
// This is only a SKELETON file for the 'Matrix' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Matrix {
  constructor(inputString) {
    this._rows = inputString.split('\n').map(row => row.split(' ').map(x => Number(x)));
    this._columns = this._rows[0].map((col, i) => this._rows.map(row => row[i]));
    //console.log(this._columns);
  }

  get rows() {
    return this._rows;
  }

  get columns() {
    return this._columns
  }
}
