function solve(input) {
  let heroes = [];

  for (let i = 0; i < input.length; i++) {
    let [name, level, itemsInput] = input[i].split(' / ');

    let hero = { name, level: Number(level), items:itemsInput?itemsInput.split(', '):[] };

    heroes.push(hero);
  }
  console.log(JSON.stringify(heroes));
}

solve([
  'Isacc / 25 /',
  'Derek / 12 / BarrelVest, DestructionSword',
  'Hes / 1 / Desolator, Sentinel, Antara',
]);
