const lookupChar = require('./charLookUp');
const { assert } = require('chai');

describe('Testing lookupChar function', () => {
  it('Test with valid first argument string, and invalid second', () => {
    assert.equal(lookupChar('hello', 'o'), undefined);
  });
  it('Test with valid first argument string, and invalid decimal second', () => {
    assert.equal(lookupChar('hello', 10.1), undefined);
  });

  it('Test with invalid first argument , and valid second', () => {
    assert.equal(lookupChar(1, 1), undefined);
  });

  it('Test with both parameters invalid', () => {
    assert.equal(lookupChar(1, '1'), undefined);
  });

  it('Test with edgecase', () => {
    assert.equal(lookupChar('', 0), 'Incorrect index');
  });

  it('Test with edgecase 2', () => {
    assert.equal(lookupChar('', -1), 'Incorrect index');
  });

  it('Test with invalid index over string length', () => {
    assert.equal(lookupChar('hi', 12), 'Incorrect index');
  });

  it('Test with invalid index equal string length', () => {
    assert.equal(lookupChar('hi', 2), 'Incorrect index');
  });

  it('Test with invalid index with negative integer', () => {
    assert.equal(lookupChar('hello', -1), 'Incorrect index');
  });

  it('Test for correct output', () => {
    assert.strictEqual(lookupChar('hello', 0), 'h');
  });

  it('Test for incorrect output', () => {
    assert.notEqual(lookupChar('hello', 1), 'h');
  });
});
