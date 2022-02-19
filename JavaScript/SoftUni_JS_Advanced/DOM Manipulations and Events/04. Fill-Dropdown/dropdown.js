function addItem() {
  let newText = document.getElementById('newItemText').value;
  let newValue = document.getElementById('newItemValue').value;

  let newOption = document.createElement('option');

  newOption.text = newText.slice();
  newOption.value = newValue.slice();

  let menu = document.getElementById('menu');
  menu.appendChild(newOption);
  document.getElementById('newItemText').value = '';
  document.getElementById('newItemValue').value = '';
}
