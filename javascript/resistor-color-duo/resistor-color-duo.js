//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const value = (colorArray) => {
  let answer = COLORS.indexOf(colorArray[0]).toString() + COLORS.indexOf(colorArray[1]).toString();
  return parseInt(answer,10);
};
export const COLORS = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey","white"];