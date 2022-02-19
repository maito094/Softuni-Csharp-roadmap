function attachEventsListeners() {
  let btnConvert = document.getElementById('convert');

  let [inputField, outputField] =
    document.querySelectorAll('input[type="text"]');

  let inputUnits = document.getElementById('inputUnits');
  let outputUnits = document.getElementById('outputUnits');
  console.log(inputField);
  console.log(outputField);

  btnConvert.addEventListener('click', operation);

  function operation(e) {
    let convert = Number(inputField.value);
    let result = 0;

    let metrics = {
      km: 1000,
      m: 1,
      cm: 0.01,
      mm: 0.001,
      mi: 1609.34,
      yrd: 0.9144,
      ft: 0.3048,
      in: 0.0254,
    };

    result = (convert * metrics[inputUnits.value]) / metrics[outputUnits.value];

    outputField.value = result;
  }
}
