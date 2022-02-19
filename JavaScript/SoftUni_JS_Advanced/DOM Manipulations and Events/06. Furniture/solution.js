function solve() {
  let [btnGenerate, btnBuy] = document.querySelectorAll('div#exercise button');
  btnGenerate.addEventListener('click', addToList);
  btnBuy.addEventListener('click', OrderOperation);
  let [inputElement, outputElement] = document.querySelectorAll(
    'div#exercise textarea',
  );
  let listElement = document.querySelector('.table tbody');

  //TODO...
  function OrderOperation(e) {
    let furnitures = Array.from(listElement.getElementsByTagName('tr'));
    let outputFirstLine = 'Bought furniture: ';
    let outputSecondLine = 'Total price: ';
    let outputThirdLine = 'Average decoration factor: ';
    let furnitureBoughtNames = [];
    let totalPrice = 0;
    let furnitureCount = 0;
    let avgDecFactor = 0;
    for (const furniture of furnitures) {
      let isChecked = furniture.querySelector(
        'td input[type="checkbox"]',
      ).checked;
      let furnitureProps = Array.from(furniture.querySelectorAll('td'));
      if (isChecked) {
        furnitureCount++;
        furnitureBoughtNames.push(furnitureProps[1].firstChild.textContent);
        totalPrice += Number(furnitureProps[2].firstChild.textContent);
        avgDecFactor += Number(furnitureProps[3].firstChild.textContent);
      }
    }
    outputFirstLine += `${furnitureBoughtNames.join(', ')}`;
    avgDecFactor /= furnitureCount;
    outputSecondLine += `${totalPrice.toFixed(2)}`;
    outputThirdLine += `${avgDecFactor}`;
    outputElement.textContent =
      outputFirstLine + '\n' + outputSecondLine + '\n' + outputThirdLine;
  }
  function addToList(e) {
    let furnitures = [];
    furnitures = JSON.parse(inputElement.value);
    for (const furniture of furnitures) {
      let tRowElement = document.createElement('tr');

      let tdElementImg = document.createElement('td');
      let imgSrc = document.createElement('img');
      imgSrc.src = furniture.img;
      tdElementImg.appendChild(imgSrc);
      tRowElement.appendChild(tdElementImg);

      let tdElementName = document.createElement('td');
      let pName = document.createElement('p');
      pName.textContent = furniture.name;
      tdElementName.appendChild(pName);
      tRowElement.appendChild(tdElementName);

      let tdElementPrice = document.createElement('td');
      let pPrice = document.createElement('p');
      pPrice.textContent = furniture.price;
      tdElementPrice.appendChild(pPrice);
      tRowElement.appendChild(tdElementPrice);

      let tdElementDecFactor = document.createElement('td');
      let pDecFactor = document.createElement('p');
      pDecFactor.textContent = furniture.decFactor;
      tdElementDecFactor.appendChild(pDecFactor);
      tRowElement.appendChild(tdElementDecFactor);

      let tdElementMark = document.createElement('td');
      let inputCheckBox = document.createElement('input');
      inputCheckBox.setAttribute('type', 'checkbox');
      tdElementMark.appendChild(inputCheckBox);
      tRowElement.appendChild(tdElementMark);
      listElement.appendChild(tRowElement);
    }

    // listElement.
    console.log(furnitures);
  }
}
