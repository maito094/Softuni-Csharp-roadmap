function solve(fruitType,weightGrams,pricePerKilo) {
    let weight = weightGrams/1000;
    let calcPrice = weight*pricePerKilo;

    console.log(`I need $${calcPrice.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${fruitType}.`);
}

solve('mandarine',1000,1.5);