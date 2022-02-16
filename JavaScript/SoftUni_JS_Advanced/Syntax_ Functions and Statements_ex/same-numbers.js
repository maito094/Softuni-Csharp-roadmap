function solve(num) {
    let intNumber = Number(num);
    let areSameNumbers = true;
    let result=0;
    let previousDigit = intNumber%10;
    while (intNumber>0) {
        
        let currentDigit = intNumber%10;
        
        result+=currentDigit;
        intNumber = Math.floor(intNumber/10);
        
        if (currentDigit!=previousDigit && areSameNumbers) {
            areSameNumbers=false;
        }
        previousDigit=currentDigit;
    }
    
    console.log(areSameNumbers);
    console.log(result);
}
solve(1234);