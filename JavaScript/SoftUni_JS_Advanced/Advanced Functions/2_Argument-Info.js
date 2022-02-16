function solve(...value) {
  typeofArgs = {};


  for (const inp of value) {
    currentInput = { type: typeof inp, val: inp };
    if (!typeofArgs[typeof inp]) {
      typeofArgs[typeof inp] = 0;
    }
    typeofArgs[typeof inp] += 1;

    console.log(`${currentInput.type}: ${currentInput.val}`);
  }
  let ordered = Object.entries(typeofArgs).sort((a, b) => b[1] - a[1]);

  for (const element of ordered) {
    console.log(`${element[0]} = ${element[1]}`);
  }
}

solve('cat', 42, 42, function () {
  console.log('Hello world!');
});
