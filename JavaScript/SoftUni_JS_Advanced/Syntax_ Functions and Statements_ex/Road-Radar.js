function solve(speed, area) {
  areaSpeedLimit = {
    motorway: 130,
    interstate: 90,
    city: 50,
    residential: 20,
  };
  let isInLimit = true;
  let msgStatus = '';
  let speedLimit = Number(areaSpeedLimit[area]);
  let speedDifference=0;

  if (Number(speed) > speedLimit) {
    isInLimit = false;
    speedDifference=Number(speed)-speedLimit;
    if (speedDifference<=20) {
        msgStatus='speeding'
    }else if (speedDifference<=40) {
        msgStatus='excessive speeding'
    }else{
        msgStatus='reckless driving'
    }
  }

  if (isInLimit) {
    console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
  } else {
    console.log(
      `The speed is ${speedDifference} km/h faster than the allowed speed of ${speedLimit} - ${msgStatus}`,
    );
  }
}
solve(130.1, 'motorway');
