(function solution() {
  Array.prototype.last = function () {
    return this[this.length - 1];
  }

  Array.prototype.skip = function (n) {
      
    // if (n < 0 || n >= this.length) {
    //   n = 0;
    // }
    return this.slice(Number(n));
  }

  Array.prototype.take = function (n) {
    // if (n < 0 || n >= this.length) {
    //   n = 0;
    // }
    return this.slice(0, Number(n));
  }

  Array.prototype.sum = function () {
    return this.reduce((a, b) => 
      a + b
    ,0);
  }

  Array.prototype.average = function () {
    return this.reduce((a, b) => (a + b), 0) / this.length;
  }
})();

let myArr = [1, 2, 3];

console.log(myArr.skip(2));
console.log(myArr.take(2));
console.log(myArr.sum());
console.log(myArr.average());
