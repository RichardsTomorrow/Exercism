//
// This is only a SKELETON file for the 'etl' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const transform = (oldSystem) => {

  let newSystem = {};
  Object.keys(oldSystem).map(value => {
    oldSystem[value].forEach(letter => {
      newSystem[letter.toLowerCase()] = Number(value)
    })
  })
  return newSystem;
};
