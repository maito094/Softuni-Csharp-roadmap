function solve(array) {
  let combinationSortedArray = [];
  let sortedArray = array;

  sortedArray.sort((a, b) => {
    return a - b;
  });

  while (sortedArray.length > 0) {
    combinationSortedArray.push(sortedArray.shift());
    combinationSortedArray.push(sortedArray.pop());
  }
  if (combinationSortedArray.indexOf(undefined) > 0) {
    let indx = combinationSortedArray.indexOf(undefined);
    combinationSortedArray.splice(indx, 1);
  }

  return combinationSortedArray;
}
console.log(solve([1, 65, 3, 52, 48, 8, 63, 31, -3, 18, 56]));
