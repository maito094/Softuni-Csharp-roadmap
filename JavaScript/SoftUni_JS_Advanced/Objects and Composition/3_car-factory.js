function solve(object) {
  const carriageChoice = function (currentObj) {
    const carriage = { type: null, color: null };
    carriage.type = currentObj.carriage;
    carriage.color = currentObj.color;

    return carriage;
  };
  const engineChoice = function (currentObj) {
    const small = { power: 90, volume: 1800 };
    const normal = { power: 120, volume: 2400 };
    const monster = { power: 200, volume: 3500 };
    const engines = [small, normal, monster];

    for (const element of engines) {
      if (
        currentObj.power === element.power ||
        currentObj.power < element.power
      ) {
        return element;
      }
    }
  };
  const wheelsizeChoice = function (currentObj) {
    let wheelsize = Math.floor(currentObj.wheelsize);

    if (wheelsize % 2 == 0) {
      wheelsize--;
    }
    let array = [0, 0, 0, 0];

    return array.fill(wheelsize, 0, 4);
  };

  let car = {
    model: object.model,
    engine: engineChoice(object),
    carriage: carriageChoice(object),
    wheels: wheelsizeChoice(object),
  };

  return car;
}

console.log(
  solve({ model: 'VW Golf II',
  power: 90,
  color: 'blue',
  carriage: 'hatchback',
  wheelsize: 14 }
),
);
