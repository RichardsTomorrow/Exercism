/* eslint-disable no-unused-vars */
//
// This is only a SKELETON file for the 'Bob' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const hey = (message) => {
  const question = message.trim().endsWith("?");
  const yell = isUpperCase(message);
  const empty = isNullOrEmpty(message);
  let answer = 'Whatever.';

  function isUpperCase(str) {
    return str == str.toUpperCase() && str != str.toLowerCase(); // some chars will return true if checked against either lower or upper, this checks against case-less chars
  }
  function isNullOrEmpty(str){
    return !str||!str.trim();
  }
  if(empty){answer = 'Fine. Be that way!';}
  else if (question && yell){answer = 'Calm down, I know what I\'m doing!';}
  else if (question){answer = 'Sure.';}
  else if (yell){answer = 'Whoa, chill out!';}
  
  return answer;
};
