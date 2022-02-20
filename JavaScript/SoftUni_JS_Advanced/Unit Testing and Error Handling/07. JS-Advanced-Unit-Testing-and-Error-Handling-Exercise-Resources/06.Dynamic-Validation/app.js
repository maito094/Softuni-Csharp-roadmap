function validate() {
  let inputField = document.querySelector('#email');

  inputField.addEventListener('change', (e) => {
    let input = e.currentTarget.value;
    let name = e.currentTarget.value.split('@')[0];
    let domain = e.currentTarget.value.slice(
      input.indexOf('@') + 1,
      input.indexOf('.'),
    );
    let extension = e.currentTarget.value.split('.')[1];

    if (
      !!name &&
      name === name.toLowerCase() &&
      !!domain &&
      domain === domain.toLowerCase() &&
      !!extension &&
      extension === extension.toLowerCase()
    ) {
      e.currentTarget.classList.remove('error');
    } else {
      e.currentTarget.classList.add('error');
    }
  });
}
