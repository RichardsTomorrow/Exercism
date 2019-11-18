//
// This is only a SKELETON file for the 'Reverse String' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const reverseString = (inputString) => {
  let temp ='';
  for (let i = 0; i < inputString.length; i++){
    temp += inputString.charAt(inputString.length - i - 1);
  }
  return temp;
};
