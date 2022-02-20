function solve(array) {
  let products = {};
  for (let i = 0; i < array.length; i += 2) {
    let productName = array[i];
    let calories = Number(array[i + 1]);
    products[productName] = calories;
    //  console.log(`${productName} <-> ${calories}`);
  }
  console.log(products);
}

solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
