class List {
  arr = [];
  size = this.arr.length;

  add(element) {
    this.arr.push(element);
    this.size = this.arr.length;
    this.arr.sort((a, b) => a - b);
  }

  remove(index) {
    if (index >= this.arr.length || index < 0) {
      return;
    }
    
     this.arr.splice(index, 1);
     this.size = this.arr.length;
     this.arr.sort((a, b) => a - b);
  }

  get(index) {
    if (index >= this.arr.length || index < 0) {
      return;
    }

    return this.arr[index];
  }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));

console.log(list.arr);
