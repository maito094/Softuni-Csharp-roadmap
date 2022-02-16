function getFibonator() {
  let movingSum = 0;
  let currentNum = 1;

  return function () {
    let curNum = 0;

    if (movingSum < 2) {
      movingSum += currentNum;
      return 1;
    }
    curNum = movingSum;

    movingSum += currentNum;
    currentNum = curNum;
    return curNum;
  };
}

let fib = getFibonator(); 
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
