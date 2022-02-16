function solve(names) {
  let filteredArr = names;
  filteredArr.sort((name1, name2) => {
    // let char = parseInt(name1.charCodeAt(0)) - parseInt(name2.charCodeAt(0));
    let char = name1.localeCompare(name2);
    return char;
  });

  for (let i = 0; i < filteredArr.length; i++) {
    console.log(`${i + 1}.${filteredArr[i]}`);
  }
}
solve(['John', 'Abob', 'Zhristina', 'Ema']);
