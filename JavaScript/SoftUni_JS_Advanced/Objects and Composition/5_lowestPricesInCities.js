function solve(input) {
  let products = [];

  while (input.length > 0) {
    let [town, product, price] = input.shift().split(' | ');
    // console.log(`${town} ${product} ${price}`);
    if (products.filter((x) => x.product === product).length > 0) {
      let obj = products.find((x) => x.product === product);

      if (obj.price > Number(price)) {
        obj.price = Number(price);
        obj.town = town;
      }
      //console.log(obj);
      //...
    } else {
      let obj = { product, town, price: Number(price) };
      products.push(obj);
    }
  }
  for (const prod of products) {
      //Orange -> 2 (Sample Town)
      console.log(`${prod.product} -> ${prod.price} (${prod.town})`);
  }
}

console.log(
  solve([
    'Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10',
  ]),
);
