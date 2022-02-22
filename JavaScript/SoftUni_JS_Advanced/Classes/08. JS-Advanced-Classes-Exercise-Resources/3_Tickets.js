function solve(arrayOfStrings, criteria) {
  class Ticket {
    constructor(destination, price, status) {
      this.destination = destination;
      this.price = Number(price);
      this.status = status;
    }
  }
  let database = [];

  arrayOfStrings.forEach((element) => {
    let ticket = new Ticket(...element.split('|'));
    database.push(ticket);
  });

  console.log(JSON.stringify(database));

  if (criteria!=='price') {
      
      database.sort((a, b) => a[criteria].localeCompare(b[criteria]));
  }else{
    database.sort((a, b) => a['price']-b['price']);
  }

  console.log(JSON.stringify(database));

  return database;
}

solve(
    ['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
'price'
);
