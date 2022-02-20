function solve(input) {
    towns=[];

    for (let i = 1; i < input.length; i++) {
        let[Town,la,lo]  = input[i].slice(2,input.length-4).split(' | ');

        let record={Town,Latitude:Number(Number(la).toFixed(2)),Longitude:Number(Number(lo).toFixed(2))};
       
        towns.push(record);
    }

    console.log(JSON.stringify(towns));
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
);