function solution() {
  let recipes = {};
  let apple = { carbohydrate: 1, flavour: 2 };
  let lemonade = { carbohydrate: 10, flavour: 20 };
  let burger = { carbohydrate: 5, fat: 7, flavour: 3 };
  let eggs = { protein: 5, fat: 1, flavour: 1 };
  let turkey = { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 };
  Object.assign(recipes, { apple, lemonade, burger, eggs, turkey });
  let stock = { protein: 0, carbohydrate: 0, fat: 0, flavour: 0 };

  return (order) => {
    let [cmd, ingridient, number] = order.split(' ');
    value = Number(number);
    if (cmd === 'restock') {
      stock[ingridient] += value;
      return 'Success';
    } else if (cmd === 'prepare') {
      for (const key in recipes[ingridient]) {
        const quantity = recipes[ingridient][key] * value;
        if (stock[key] - quantity >= 0) {
          stock[key] -= quantity; //should replenish if failed to successfuly cook?????
        } else {
          return `Error: not enough ${key} in stock`;
        }
      }
      return 'Success';
    } else if (cmd === 'report') {
      return `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`;
    }
  };
}

let manager = solution();
console.log(manager('restock flavour 50')); // Success
console.log(manager('prepare lemonade 4')); // Error: not enough carbohydrate in stock
// console.log(manager('restock carbohydrate 10')); // Error: not enough carbohydrate in stock
// console.log(manager('restock flavour 10')); // Error: not enough carbohydrate in stock
// console.log(manager('prepare apple 1')); // Error: not enough carbohydrate in stock
// console.log(manager('restock fat 10')); // Error: not enough carbohydrate in stock
// console.log(manager('prepare burger 1')); // Error: not enough carbohydrate in stock
// console.log(manager('report')); // Error: not enough carbohydrate in stock
