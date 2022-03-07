function getStudentCollection() {
  const baseURL = 'http://localhost:3030/jsonstore/collections/students';

  let tableBodyElement = document.querySelector('#results tbody');
  let formElement = document.getElementById('form');

  formElement.addEventListener('submit', onSubmitCreateStudent);
  window.addEventListener('load', onLoadGetStudents);

  function onSubmitCreateStudent(ev) {
    ev.preventDefault();

    // When using Form Element and attach an EventListener, while passing the currentTarget as an argument in FormData object,
    // the get method of FormData will take as an argument the "name" of desired input element and return the entered value
    // after submit button is pressed
    let formData = new FormData(ev.currentTarget);

    let firstName = formData.get('firstName');
    let lastName = formData.get('lastName');
    let facultyNumber = Number(formData.get('facultyNumber'));
    let grade = Number(formData.get('grade'));

    if (!firstName || !lastName || !facultyNumber || !grade) {
      return;
    }
    let dataEntry = { firstName, lastName, facultyNumber, grade };
    
    tableBodyElement.appendChild(
        e('tr', null, [
          e('td', null, firstName),
          e('td', null, lastName),
          e('td', null, facultyNumber),
          e('td', null, grade),
        ])
      );
    postRequest(dataEntry);
    //onLoadGetStudents();

    ev.currentTarget.reset(); // Resets the input fields of the Form Element
  }

  async function postRequest(dataEntry) {
    let response = await fetch(baseURL, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(dataEntry),
    });
  }

  async function onLoadGetStudents() {
    tableBodyElement.innerHTML = '';
    const respnse = await fetch(baseURL);
    const data = await respnse.json();

    Object.values(data).forEach((entry) => {
      let { firstName, lastName, facultyNumber, grade, _id } = entry;

      tableBodyElement.appendChild(
        e('tr', null, [
          e('td', null, firstName),
          e('td', null, lastName),
          e('td', null, facultyNumber),
          e('td', null, grade),
        ])
      );
    });
  }

  // DOM Element Factory Function
  function e(type, attributes, ...content) {
    const result = document.createElement(type);

    for (let [attr, value] of Object.entries(attributes || {})) {
      if (attr.substring(0, 2) == 'on') {
        result.addEventListener(attr.substring(2).toLocaleLowerCase(), value);
      } else {
        if (value === '') {
          result.setAttribute(attr, '');
        } else {
          result[attr] = value;
        }
      }
    }

    content = content.reduce(
      (a, c) => a.concat(Array.isArray(c) ? c : [c]),
      []
    );

    content.forEach((e) => {
      if (typeof e == 'string' || typeof e == 'number') {
        const node = document.createTextNode(e);
        result.appendChild(node);
      } else {
        result.appendChild(e);
      }
    });

    return result;
  }
}
getStudentCollection();
