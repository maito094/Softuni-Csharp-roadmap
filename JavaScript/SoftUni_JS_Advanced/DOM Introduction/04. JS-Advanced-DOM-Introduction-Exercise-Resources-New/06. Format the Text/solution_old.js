function solve() {
  let textInput = document.getElementById('input').value.split('.');
  //let toggleClosing = false;
  let output = document.getElementById('output');

  let numberOfParagraphs = Math.round(textInput.length / 3);
  // console.log(textInput);
  // console.log(numberOfParagraphs);
  let j = 0;
  if (numberOfParagraphs === 1) {
    let currentText = textInput.join('.');
    output.innerHTML += `<p>${currentText}</p>`;
  } else {
    for (let i = 0; i < numberOfParagraphs; i++) {
      let currentText = '';
      while (j < (1 + i) * 3 && j < textInput.length - 1) {
        currentText += `${textInput[j]}.`;
        j++;
      }
      output.innerHTML += `<p>${currentText}</p>`;
    }
  }
}
