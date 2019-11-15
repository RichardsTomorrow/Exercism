//
// This is only a SKELETON file for the 'RNA Transcription' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const toRna = (dna) => {
  let answer = '';
  var rnaDict ={
    A:'U',
    T:'A',
    G:'C',
    C:'G'
  };
return dna.split('').map(nucleotide => rnaDict[nucleotide]).join('');
};
