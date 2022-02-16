function solve(array, num) {
  let rotatedArray = array;
  for (let i = 0; i < num; i++) {
    let lastElement = rotatedArray.pop();
    rotatedArray.unshift(lastElement);
  }
  console.log(rotatedArray.join(' '));
}
solve(['1', '2', '3', '4'], 2);
