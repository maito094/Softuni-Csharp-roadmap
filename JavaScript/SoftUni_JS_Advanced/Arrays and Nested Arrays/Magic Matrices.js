function solve(matrix) {
  let isMagical = false;
  let nRows = matrix.length;
  let sumRows = 0;
  let sumFirstRow = 0;
  let sumFirstCol = 0;
  for (let j = 0; j < nRows; j++) {
    for (let i = 0; i < matrix[j].length; i++) {
      if (j == nRows % 2) {
        sumFirstRow += matrix[j][i];
      }
      if (i == matrix[j].length % 2) {
        sumFirstCol += matrix[j][i];
      }
      sumRows += matrix[j][i];
    }
  }
  if (sumRows / nRows == sumFirstRow && sumRows / nRows == sumFirstCol) {
    isMagical = true;
  }
  return isMagical;
}
console.log(
  solve([
    [1, 1, 0,1],
    [1, 0, 1,1],
    [0, 1, 1,1],
    [1, 1, 1,0],
  ]),
);
