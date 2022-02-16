function solve(num1,num2) {
let number1 = Number(num1);
let number2 = Number(num2);
let biggerNumber;
let smallerNumber;
let GCD;

if (number1>number2) {
    biggerNumber=number1;
    smallerNumber=number2;
}
else{
    biggerNumber=number2;
    smallerNumber=number1;
}
GCD=smallerNumber;

while (biggerNumber%GCD!=0 || smallerNumber%GCD!=0) {

    GCD--;
   
}

console.log(GCD);

}
solve(2154, 458);
