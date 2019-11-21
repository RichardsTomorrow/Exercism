//
// This is only a SKELETON file for the 'Grade School' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class GradeSchool {
   constructor(){
     this._roster = {};
   }

  roster() {
    return JSON.parse(JSON.stringify(this._roster));
  }

  add(student, grade) {
    if(!this._roster.hasOwnProperty(grade)){
      this._roster[grade] = [student];
    } else {
      this._roster[grade].push(student);
      this._roster[grade].sort();
    }
  }

  grade(grade) {
    if(this._roster.hasOwnProperty(grade)){
      return [...this._roster[grade]];
    } else {return [];}
  }
}

