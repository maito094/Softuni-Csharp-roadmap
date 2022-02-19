function generateReport() {
  let result = document.getElementById('output');

  let tickCols = document.querySelectorAll(
    "thead tr th input[type='checkbox']",
  );
  console.log(tickCols);

  let tableBodyElement = document.querySelectorAll('tbody tr');
  //console.log(tableBodyElement);
  let selection = [];

  for (let i = 0; i < tableBodyElement.length; i++) {
    let selected = {};

    for (let j = 0; j < tickCols.length; j++) {
      if (tickCols[j].checked) {
        selected[tickCols[j].name] =
          tableBodyElement[i].getElementsByTagName('td')[j].textContent;
      }
    }
    selection.push(selected);
  }
  //   console.log(selection);
  result.textContent=JSON.stringify(selection);
}
