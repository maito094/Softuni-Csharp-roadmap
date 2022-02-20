const { assert } = require('chai');
const sum = require('./1_sum');

describe('Sum Caclucaltor', () => {
  it('Should Return Correct Sum From Two Positive Numbers', () => {
    //Arrange
    let expectedSum = 10;
    let num1 = 3;
    let num2 = 7;
    //Act

    let actualSum = sum(num1, num2);
    //Assert

    assert.equal(actualSum, expectedSum);
  });

  it('Should Return Correct Sum From Two Negative Numbers', () => {
    //Arrange
    let expectedSum = -10;
    let num1 = -3;
    let num2 = -7;
    //Act

    let actualSum = sum(num1, num2);
    //Assert

    assert.equal(actualSum, expectedSum);
  });
});
