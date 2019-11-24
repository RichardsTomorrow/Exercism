//
// This is only a SKELETON file for the 'Nucleotide-Count' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class NucleotideCounts {
  static parse(dna) {
    let [a, c, g, t] = [0, 0, 0, 0];
    dna = dna.toUpperCase();
    for( let i = 0; i < dna.length; i++){
      if (dna.charAt(i) === "A"){a++;}
      else if (dna.charAt(i) === "C"){c++;}
      else if (dna.charAt(i) === "G"){g++;}
      else if (dna.charAt(i) === "T"){t++;}
      else {throw new Error('Invalid nucleotide in strand');}
    }
    return `${a} ${c} ${g} ${t}`;
  }
}
