class Company {
  departments = {};
  constructor() {}

  addEmployee(name, salary, position, department) {
    if (!name || salary < 0 || !salary || !position || !department) {
      throw new Error('Invalid input!');
    }
    let employee = { name, salary: Number(salary), position, department };
    if (!this.departments[department]) {
      this.departments[department] = [];
    }
    this.departments[department].push(employee);

    return `New employee is hired. Name: ${name}. Position: ${position}`;
  }

  bestDepartment() {
    let curBestDep = '';
    let curBestAvgSalary = 0;
    for (const dep in this.departments) {
      let i = 0;
      const element = this.departments[dep];
      let depAvgSalary = 0;
      for (const emp of element) {
        depAvgSalary += emp.salary;
        i++;
      }
      depAvgSalary /= i;
      if (depAvgSalary > curBestAvgSalary) {
        curBestAvgSalary = depAvgSalary;
        curBestDep = dep;
      }
    }
    this.departments[curBestDep].sort(function (a, b) {
      if (b.salary - a.salary !== 0) {
        return b.salary - a.salary;
      } else {
        return a.name.localeCompare(b.name);
      }
    });
    let result = `Best Department is: ${curBestDep}\nAverage salary: ${curBestAvgSalary.toFixed(
      2,
    )}`;
    for (const employee of this.departments[curBestDep]) {
      result += `\n${employee.name} ${employee.salary} ${employee.position}`;
    }
    return result;
  }
}
//empty string (""), undefined or null
let c = new Company();
c.addEmployee('Gosho', 1000, 'engineer', null);
c.addEmployee('Pesho', 1500, 'electrical engineer', 'Construction');
c.addEmployee('Slavi', 500, 'dyer', 'Construction');
c.addEmployee('Stan', 2000, 'architect', 'Construction');
c.addEmployee('Stanimir', 1200, 'digital marketing manager', 'Marketing');
c.addEmployee('Pesho', 1000, 'graphical designer', 'Marketing');
c.addEmployee('Gosho', 1350, 'HR', 'Human resources');
console.log(c.bestDepartment());
