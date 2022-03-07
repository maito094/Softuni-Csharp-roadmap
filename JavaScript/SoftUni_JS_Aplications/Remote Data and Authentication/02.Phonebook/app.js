const baseURL = 'http://localhost:3030/jsonstore/phonebook';
//load all entries and Dipslay them

let phonebookElement = document.getElementById('phonebook');
let btnLoad = document.getElementById('btnLoad');

let personInput = document.getElementById('person');
let phoneInput = document.getElementById('phone');
let btnCreate = document.getElementById('btnCreate');

function attachEvents() {
  btnLoad.addEventListener('click', loadPhonebookHandler);
  btnCreate.addEventListener('click', createContactHandler);
}

async function createContactHandler() {
  let [person, phone] = [personInput.value, phoneInput.value];

  let entry = {
    person,
    phone,
  };

  if (!person || !phone) {
    return;
  }

  let response = await fetch(baseURL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(entry),
  });
  let entryData = await response.json();

  createContact(entryData);
  personInput.value = '';
  phoneInput.value = '';
}

function createContact(entry) {
  let liElement = document.createElement('li');
  liElement.textContent = `${entry.person}: ${entry.phone}`;
  let btnDelete = document.createElement('button');
  btnDelete.textContent = 'Delete';

  btnDelete.addEventListener(
    'click',
    deleteEntryHandler.bind(btnDelete, entry._id), // Another way is to just assign an id on the HTML Element of the li or the delete button
    false
  );

  liElement.appendChild(btnDelete);

  phonebookElement.appendChild(liElement);
}
async function loadPhonebookHandler() {
  phonebookElement.innerHTML = '';
  const res = await fetch(baseURL);
  const data = await res.json();
  //map(({person, phone, _id})=>{.....} Using map and destructuring the Entry is also viable option
  Object.values(data).forEach((entry) => {
    createContact(entry);
  });
}

async function deleteEntryHandler(_id) {
  let response = await fetch(baseURL + `/${_id}`, {
    method: 'DELETE',
    'Content-Type': 'application/json',
  });

  this.parentElement.remove();
  //console.log(response);
}
attachEvents();
