const mathEnforcer = require('./mathEnforcer');
const { assert } = require('chai');

describe('mathEnforcer functionality test', () => {
  describe('AddFive function test', () => {
    it('Incorrect parameter input should return undefined', () => {
      assert.equal(mathEnforcer.addFive(''), undefined);
    });

    it('Should return correct result', () => {
      assert.equal(mathEnforcer.addFive(5), 10);
    });

    it('Should return correct result with negative', () => {
      assert.equal(mathEnforcer.addFive(-5), 0);
    });

    it('Should return correct result with decimal', () => {
      assert.equal(mathEnforcer.addFive(5.5), 10.5);
    });

    it('Should return incorrect result', () => {
      assert.notEqual(mathEnforcer.addFive(5), 65);
    });
  });

  describe('subtractTen function test', () => {
    it('Incorrect parameter input should return undefined', () => {
      assert.equal(mathEnforcer.subtractTen(''), undefined);
    });
    it('Should return correct result', () => {
      assert.equal(mathEnforcer.subtractTen(15), 5);
    });
    it('Should return correct result with negative', () => {
      assert.equal(mathEnforcer.subtractTen(-10), -20);
    });
    it('Should return correct result with decimal', () => {
      assert.equal(mathEnforcer.subtractTen(15.5), 5.5);
    });

    it('Should return incorrect result', () => {
      assert.notEqual(mathEnforcer.subtractTen(5), 65);
    });
  });

  describe('sum function test', () => {
    it('Incorrect parameter input 1 should return undefined', () => {
      assert.equal(mathEnforcer.sum('', 1), undefined);
    });

    it('Incorrect parameter input 2 should return undefined', () => {
      assert.equal(mathEnforcer.sum(1, ''), undefined);
    });

    it('Should return correct result', () => {
      assert.equal(mathEnforcer.sum(1, 5), 6);
    });

    it('Should return correct result with decimal', () => {
      assert.equal(mathEnforcer.sum(1.5, 5.5), 7);
    });
    it('Should return correct result with negative number', () => {
      assert.equal(mathEnforcer.sum(-1, -5), -6);
    });

    it('Should return correct result with negative number', () => {
      assert.equal(mathEnforcer.sum(1, -5), -4);
    });

    it('Should return correct result with negative number', () => {
      assert.equal(mathEnforcer.sum(-1, 5), 4);
    });
  });
});
