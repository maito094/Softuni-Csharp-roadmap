function rectangle(width,height,color) {
    
    let rectangle ={width: Number(width),height: Number(height),color:color[0].toUpperCase()+color.slice(1,color.length), calcArea(){
return this.height*this.width;
    }};

    return rectangle;
}

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
