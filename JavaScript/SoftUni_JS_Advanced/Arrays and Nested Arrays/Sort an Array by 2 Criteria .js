function solve(array) {
  let sortedArray = [];
  sortedArray = array.slice();

  sortedArray.sort((a, b) => {
    if (a.length - b.length == 0) {
      return a.localeCompare(b);
    }
    return a.length - b.length;
  });

  sortedArray.forEach(element => {
      console.log(element);
  });
}
solve(['test', 'Deny', 'omen', 'Default']);
