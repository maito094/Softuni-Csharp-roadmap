const isOddOrEven = require('./isOddOrEven');
const { assert } = require('chai');

describe('Testing isOddOrEven function', () => {
  it('should return undefined if parameter is number', () => {
    assert.equal(isOddOrEven(10), undefined);
  });

  it('should return undefined if parameter is object', () => {
    assert.equal(isOddOrEven({}), undefined);
  });

  it('should return undefined if parameter is array', () => {
    assert.equal(isOddOrEven([]), undefined);
  });

  it('should return undefined if parameter is undefined', () => {
    assert.equal(isOddOrEven(undefined), undefined);
  });

  it('should return undefined if parameter is null', () => {
    assert.equal(isOddOrEven(null), undefined);
  });

  it('should return valid even result', () => {
    assert.equal(isOddOrEven('hi'), 'even');
  });

  it('should return valid odd result', () => {
    assert.equal(isOddOrEven('hid'), 'odd');
  });

 
});
