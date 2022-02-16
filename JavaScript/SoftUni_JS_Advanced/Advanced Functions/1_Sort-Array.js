function result(array, op) {
  let sortedFunc = {
    array,
    op,
    sorting() {
      let sortedArray = [];
      if (this.op === 'asc') {
        sortedArray = this.array.sort((a, b) => a - b);
      } else if (this.op === 'desc') {
        sortedArray = this.array.sort((a, b) => b - a);
      }

      return sortedArray;
    },
  };

  return sortedFunc.sorting();
}

console.log(result([14, 7, 17, 6, 8], 'asc'));
console.log(result([14, 7, 17, 6, 8], 'desc'));
