// function solve(array) {
//   let filteredArr = [];
//   let biggestValue = 0;
//   filteredArr = array.filter((curValue) => {
//     let isGreater = false;
//     if (curValue > biggestValue) {
//       biggestValue = curValue;
//       isGreater = true;
//     }
//     return isGreater;
//   });
//   return filteredArr;
// }
function solve(array) {
   
  let filteredArr = [];
  let biggestValue=0;
 
for (let i = 0; i < array.length; i++) {

   if (biggestValue<=array[i]) {
       biggestValue=array[i];
       filteredArr.push(biggestValue);
   }

}

  return filteredArr;
}
console.log(solve([11, 3, 8, 4, 10, 12, 3, 12, 24]));
