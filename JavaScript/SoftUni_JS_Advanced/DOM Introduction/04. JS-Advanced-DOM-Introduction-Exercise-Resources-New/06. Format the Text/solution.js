function solve() {
  let textInput = document
    .getElementById('input')
    .value.split('.')
    .filter((s) => s !== '');
  let outputDiv = document.getElementById('output');

  while (textInput.length > 0) {
    let text = textInput.splice(0, 3).join('. ') + '.';
    let p = document.createElement('p');
    p.textContent = text;
    outputDiv.appendChild(p);
  }
}
