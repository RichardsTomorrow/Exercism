//
// This is only a SKELETON file for the 'Space Age' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const age = (planet, seconds) => {

  let OnEarth = (seconds) =>{
    return seconds/31557600;
  }
if ( planet == 'earth'){
  return Number(OnEarth(seconds).toFixed(2));
} else if ( planet == 'mercury'){
  return Number((OnEarth(seconds)/ 0.2408467).toFixed(2));
}else if ( planet == 'venus'){
  return Number((OnEarth(seconds)/ 0.61519726).toFixed(2));
}else if ( planet == 'mars'){
  return Number((OnEarth(seconds)/ 1.8808158).toFixed(2));
}else if ( planet == 'jupiter'){
  return Number((OnEarth(seconds)/ 11.862615).toFixed(2));
}else if ( planet == 'saturn'){
  return Number((OnEarth(seconds)/ 29.447498).toFixed(2));
}else if ( planet == 'uranus'){
  return Number((OnEarth(seconds)/ 84.016846).toFixed(2));
}else if ( planet == 'neptune'){
  return Number((OnEarth(seconds)/ 164.79132).toFixed(2));
}
  
};
