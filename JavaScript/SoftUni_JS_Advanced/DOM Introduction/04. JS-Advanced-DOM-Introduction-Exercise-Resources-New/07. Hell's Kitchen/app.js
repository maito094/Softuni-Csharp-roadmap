function solve() {
  document.querySelector('#btnSend').addEventListener('click', onClick);

  function onClick() {
    let textInput = JSON.parse(
      document.querySelector('#inputs textarea').value,
    );

    let restaurantArr = [];

    let currBestName = '';
    let currBestAverageSalary = 0;

    for (const bussines of textInput) {
      let [restaurantName, workers] = bussines.split(' - ');
      let employees = workers.split(' ').filter((x, i) => i % 2 == 0);
      let salaries = workers
        .split(' ')
        .filter((x, i) => i % 2 != 0)
        .map((s) => Number(s.replace(',', '')));

      let restaurant = {
        name: '',
        workers: [],
        avgSalary: 0,
      };
      // console.log(restaurantName);
      // console.log(employees);
      // console.log(salaries);
      let avgSalary = 0;
      let isExist = false;
      if (restaurantArr.some((n) => n.name === restaurantName)) {
        isExist = true;
        restaurant = restaurantArr.find((n) => n.name === restaurantName);
      } else {
        isExist = false;
        restaurant.name = restaurantName;
      }

      for (let i = 0; i < employees.length; i++) {
        let worker = {
          workerName: '',
          salary: 0,
        };

        worker.workerName = employees[i];
        worker.salary = salaries[i];
        avgSalary += salaries[i];
        restaurant.workers.push(worker);
      }
      //console.log(restaurant.workers);
      let tmpAvrgSalary = restaurant.workers.reduce((a, b) => a + b.salary, 0);
      restaurant.avgSalary = tmpAvrgSalary / restaurant.workers.length;
      restaurant.workers = restaurant.workers.sort(
        (a, b) => b.salary - a.salary,
      );

      if (!isExist) {
        restaurantArr.push(restaurant);
      }
    }

    for (const element of restaurantArr) {

      if (element.avgSalary > currBestAverageSalary) {
        currBestName = element.name;
        currBestAverageSalary = element.avgSalary;
      }
    }

    //  console.log(textInput);
    //  console.log(restaurantArr);
    let bestRestaurantElement = document.querySelector('#bestRestaurant p');
    let bestWorkersElement = document.querySelector('#workers p');

    bestRestaurantElement.textContent = `Name: ${currBestName} Average Salary: ${currBestAverageSalary.toFixed(
      2,
    )} Best Salary: ${restaurantArr
      .find((n) => n.name === currBestName)
      .workers[0].salary.toFixed(2)}`;

    let workersInRestaurantText = '';
    for (const worker of restaurantArr.filter((n) => n.name === currBestName)[0]
      .workers) {
      workersInRestaurantText += `Name: ${worker.workerName} With Salary: ${worker.salary} `;
    }
    //   Name: {worker2 name} With Salary: {worker2 salary} Name: {worker3 name} With Salary: {worker3 salary}…`

    bestWorkersElement.textContent = workersInRestaurantText;
  }
}
