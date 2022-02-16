function solve(cmds) {
  let number = 1;
  let array = [];
  for (const cmd of cmds) {
    if (cmd == 'add') {
      array.push(number);
    } else if (cmd == 'remove') {
      array.pop();
    }
    number++;
  }

  if (array.length > 0) {
    for (const num of array) {
      console.log(num);
    }
  } else {
    console.log('Empty');
  }
}
solve(['add', 'add', 'remove', 'add', 'add']);
