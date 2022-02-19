function create(words) {
  let inputStringArr = words;

  let mainDivElement = document.getElementById('content');

  for (const input of inputStringArr) {
    let divElement = document.createElement('div');
    let pElement = document.createElement('p');
    pElement.textContent = input;
    pElement.style.display = 'none';
    divElement.addEventListener('click', (e) => {
      let hiddenParagrahp = e.currentTarget.querySelector('p');
      hiddenParagrahp.style.display = 'block';
    });
    divElement.appendChild(pElement);
    mainDivElement.appendChild(divElement);
  }
}
