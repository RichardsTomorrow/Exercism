//
// This is only a SKELETON file for the 'Pascals Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
  constructor(numRows) {
    this._rows = [[1]];
    for(let i = 1; i < numRows; i++){
      let prevRow = this._rows[i-1];
      let newRow =[];
      for(let j = 0; j <= prevRow.length; j++){
        const left = prevRow[j-1] || 0;
        const right = prevRow[j] || 0;
        newRow.push(left + right);
      }
      this._rows.push(newRow);
    }
    //console.log(this._rows);
  }

  get lastRow() {
    return this._rows[this._rows.length - 1];
  }

  get rows() {
    return this._rows;
  }
}

///new Triangle(4);