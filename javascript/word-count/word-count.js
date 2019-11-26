export class Words {
  count(input) {
    let cleanedUp = input
    .toLowerCase().replace(/\s+/g,' ').trim() //string processing
    .split(' ');  // now array processing
    let answer = {};
    cleanedUp.forEach(word => {
      if (answer.hasOwnProperty(word)){
        answer[word]++;
      } else{
        answer[word] = 1;
      }
    });
    return answer;
  }
}
