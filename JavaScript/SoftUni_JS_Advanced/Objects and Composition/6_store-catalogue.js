function solve(input) {
  let result = input.sort((a, b) => a.localeCompare(b));
  
  let currentElement = [];
  let char='';
  for (let i = 0; i < result.length; i++) {
       currentElement = result[i].split(" : ");
       if (result[i][0]!==char) {
        char=result[i][0];
            console.log(char)
       }
       console.log(`  ${currentElement[0]}: ${currentElement[1]}`);
   
      
  }


}
//   console.log(result[0][0]);
//   for (let i = 1; i < result.length; i++) {

//       console.log("  "+ result[i-1].split(" :")[0]+":"+result[i-1].split(" :")[1]);
//       if (result[i-1][0]!==result[i][0]) {
//           console.log(result[i][0]);
//       }

//   }
//   console.log("  "+ result[result.length-1].split(" :")[0]+":"+result[result.length-1].split(" :")[1]);


solve([
  'Appricot : 20.4',
  'Fridge : 1500',
  'TV : 1499',
  'Deodorant : 10',
  'Boiler : 300',
  'Apple : 1.25',
  'Anti-Bug Spray : 15',
  'T-Shirt : 10',
]);
