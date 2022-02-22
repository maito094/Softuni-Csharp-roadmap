class Hex {
  constructor(value) {
    this.number = value;
  }

  valueOf() {
    return this.number;
  }
  plus(numberHex) {
    let result;
    if (typeof numberHex === 'object') {
      result = new Hex(this.number + numberHex.number);
    } else {
      result = new Hex(this.number + numberHex);
    }

    return result;
  }
  minus(numberHex) {
    let result;

    if (typeof numberHex === 'object') {
      result = new Hex(this.number - numberHex.number);
    } else {
      result = new Hex(this.number - numberHex);
    }

    return result;
  }
  parse(str) {
    return parseInt(str, 16);
  }

  toString() {
    return `0x${this.number.toString(16).toUpperCase()}`;
  }
}

let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.minus(b).toString());
console.log(a.plus(b).toString() === '0xF');
console.log(FF.parse('AAA'));
