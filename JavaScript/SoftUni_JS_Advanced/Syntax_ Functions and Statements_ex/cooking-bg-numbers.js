function solve(number,...operators) {
    let num = Number(number);
    let operations = operators;
    for (const op of operations) {
        if (op==='chop') {
            num/=2;
        }else if (op==='dice') {
            num=Math.sqrt(num);
        }else if (op==='spice') {
          num++;  
        }else if (op==='bake') {
            num*=3;
        }else if (op==='fillet') {
            num-=num*0.2;
        }
        console.log(num);
    }
}
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');