//
// This is only a SKELETON file for the 'Perfect Numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const classify = (number) => {
  if (number <= 0){
    throw new Error('Classification is only possible for natural numbers.');
  }
  let sum = 0;
  for (let x = 1; x < number; x++){
      if (number % x == 0){
          sum += x;
      }
  }
  if (sum === number){return 'perfect';}
  else if (sum > number){return 'abundant';}
  else if (sum < number){return 'deficient';}
};
