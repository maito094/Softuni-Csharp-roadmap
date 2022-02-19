function solve() {

  
  function caseSelect(caseParam) {
    let el = textArray.shift().toLowerCase();

    if (caseParam === camel) {
      transformedText += el[0].toLowerCase() + el.slice(1, el.length);
    } else if (caseParam === pascal) {
      transformedText += el[0].toUpperCase() + el.slice(1, el.length);
    }

    while (textArray.length > 0) {
      el = textArray.shift().toLowerCase();
      transformedText += el[0].toUpperCase() + el.slice(1, el.length);
    }
  }


  let textElement = document.querySelector('input[type="text"]');
  let textArray = String(textElement.value).split(' ');
  let resultElement = document.getElementById('result');

  let transformedText = '';
  const camel = 'Camel Case';
  const pascal = 'Pascal Case';

  let nameConvention = String(document.getElementById('naming-convention').value);

  if (
    nameConvention!==camel  &&
    nameConvention!==pascal
  ) {
    resultElement.textContent = 'Error!';
  } else {
    caseSelect(nameConvention);
    resultElement.textContent = transformedText;
  }


}
