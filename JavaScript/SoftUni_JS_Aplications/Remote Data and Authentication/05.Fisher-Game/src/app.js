//window.location.assign('index.html');
window.addEventListener('load', loadInit);

const catchesURL = 'http://localhost:3030/data/catches';
const logoutURL = 'http://localhost:3030/users/logout';

let catchesMainElement = document.querySelector('#main');
let catchesElement = catchesMainElement.querySelector('#catches');
let welcomeUser = document.querySelector('.email span');
let guestElement = document.getElementById('guest');
let logoutBtn = document.getElementById('logout');
let loadBtn = document.querySelector('.load');
let addForm = document.getElementById('addForm');
let addBtn = addForm.querySelector('.add');

loadBtn.addEventListener('click', loadCatchesHandler);
addForm.addEventListener('submit', addCatchHandler);

function loadInit(ev) {
  const authorizedUser = checkAuth();

  if (!authorizedUser) {
    addBtn.setAttribute('disabled', '');
    guestElement.style.display = 'inline';

    logoutBtn.style.display = 'none';
    logoutBtn.removeEventListener('click', logoutHandler);
  } else {
    guestElement.style.display = 'none';
    welcomeUser.textContent = authorizedUser.email;
    addBtn.removeAttribute('disabled');

    logoutBtn.style.display = 'inline';
    logoutBtn.addEventListener('click', logoutHandler);
  }
}

async function logoutHandler(ev) {
  const authorizedUser = checkAuth();

  if (!authorizedUser) {
    alert('Non Authorized User tried to Logout');
    return;
  }

  let res = await fetch(logoutURL, {
    method: 'GET',
    headers: {
      'X-Authorization': `${authorizedUser.accessToken}`,
      'content-type': 'application/json',
    },
  });

  if (res.status != 204 && res.status != 200) {
    alert('Logout Was not Successfull !');
  } else {
    sessionStorage.removeItem('user');
    alert('Logout Was Successfull !');

    location.reload();
  }
}

async function loadCatchesHandler(ev) {
  catchesElement.replaceChildren();

  let res = await fetch(catchesURL);
  let data = await res.json();

  Object.values(data).forEach((c) => {
    appendCatch(c);
  });

  catchesMainElement.style.display = 'inline';
}

async function addCatchHandler(ev) {
  ev.preventDefault();
  let formData = new FormData(ev.currentTarget);

  let entry = [...formData.entries()].reduce(
    (p, [k, v]) => Object.assign(p, { [k]: v }),
    {}
  );

  // Check for Non-Empty values from the User Input Form
  let invalidData = Object.values(entry).some((x) => !x);
  if (invalidData) {
    alert('Invalid Data entered');
    return;
  }

  const authorizedUser = checkAuth();

  let res = await fetch(catchesURL, {
    method: 'POST',
    headers: {
      'X-Authorization': `${authorizedUser.accessToken}`,
      'content-type': 'application/json',
    },
    body: JSON.stringify(entry),
  });

  let data = await res.json();
  appendCatch(data);
}

// Helping Function to reduce duplicate code when appending Catch to HTML tree
// Differentiate if user is logged, so buttons are/are not Disabled
// Attach EventListeners to the buttons of the Catch Record to which the User owner ID are same
function appendCatch(data) {
  let {
    _ownerId,
    angler,
    weight,
    species,
    location,
    bait,
    captureTime,
    _createdOn,
    _id,
  } = data;

  // First Create all Input Elements with Disabled attribute
  let resultElement = e('div', { id: `${_ownerId}`, className: 'catch' }, [
    e('label', null, 'Angler'),
    e(
      'input',
      {
        type: 'text',
        className: 'angler',
        value: `${angler}`,
        disabled: '',
      },
      ''
    ),
    e('label', null, 'Weight'),
    e(
      'input',
      {
        type: 'text',
        className: 'weight',
        value: `${weight}`,
        disabled: '',
      },
      ''
    ),
    e('label', null, 'Species'),
    e(
      'input',
      {
        type: 'text',
        className: 'species',
        value: `${species}`,
        disabled: '',
      },
      ''
    ),
    e('label', null, 'Location'),
    e(
      'input',
      {
        type: 'text',
        className: 'location',
        value: `${location}`,
        disabled: '',
      },
      ''
    ),
    e('label', null, 'Bait'),
    e(
      'input',
      { type: 'text', className: 'bait', value: `${bait}`, disabled: '' },
      ''
    ),
    e('label', null, 'Capture Time'),
    e(
      'input',
      {
        type: 'number',
        className: 'captureTime',
        value: `${captureTime}`,
        disabled: '',
      },
      ''
    ),
    e(
      'button',
      {
        disabled: '',
        className: 'update',
        id: `${_id}`,
      },
      'Update'
    ),
    e(
      'button',
      {
        disabled: '',
        className: 'delete',
        id: `${_id}`,
      },
      'Delete'
    ),
  ]);

  // Attach them to a fragment for faster performance
  let fragment = document.createDocumentFragment();
  fragment.appendChild(resultElement);

  // Check if User is Logged, if so remove Disabled Input fields
  const authorizedUser = checkAuth();
  if (authorizedUser) {
    if (authorizedUser._id == _ownerId) {
      Array.from(fragment.querySelectorAll('input, button')).forEach((e) => {
        e.removeAttribute('disabled');

        if (e.tagName == 'BUTTON') {
          if (e.className == 'update') {
            e.addEventListener('click', updateCatchHandler);
          } else if (e.className == 'delete') {
            e.addEventListener('click', deleteCatchHandler);
          }
        }
      });
    }
  }

  async function updateCatchHandler(ev) {
    let record = ev.currentTarget.parentElement;
    let catchID = ev.currentTarget.id;
    let inputFields = Array.from(record.querySelectorAll('input')).map(
      (e) => e.value
    );
    let body = JSON.stringify({
      angler: `${inputFields[0]}`,
      weight: `${inputFields[1]}`,
      species: `${inputFields[2]}`,
      location: `${inputFields[3]}`,
      bait: `${inputFields[4]}`,
      captureTime: Number(`${inputFields[5]}`),
    });

    //console.log(body);
    let res = await fetch(catchesURL + `/${catchID}`, {
      method: 'PUT',
      headers: {
        'X-Authorization': `${authorizedUser.accessToken}`,
        'content-type': 'application/json',
      },
      body,
    });
    if (res.status == 200) {
      alert('Catch was successfuly updated');
    }
  }

  async function deleteCatchHandler(ev) {
    let record = ev.currentTarget.parentElement;
    let catchID = ev.currentTarget.id;

    let res = await fetch(catchesURL + `/${catchID}`, {
      method: 'DELETE',
      headers: { 'X-Authorization': `${authorizedUser.accessToken}` },
    });
    if (res.status == 200) {
      alert('Catch was successfuly deleted');
    }
    record.remove();
  }

  // Append the Catch DIV element to the DOM tree
  catchesElement.appendChild(fragment);

  // Input data from Server
  // {
  //     "_ownerId": "35c62d76-8152-4626-8712-eeb96381bea8",
  //     "angler": "Paulo Admorim",
  //     "weight": 636,
  //     "species": "Atlantic Blue Marlin",
  //     "location": "Vitoria, Brazil",
  //     "bait": "trolled pink",
  //     "captureTime": 80,
  //     "_createdOn": 1614760714812,
  //     "_id": "07f260f4-466c-4607-9a33-f7273b24f1b4"
  // }
}

function checkAuth() {
  let user = sessionStorage.getItem('user');
  if (user) {
    return JSON.parse(user);
  }
}

// Helping function. Factory function for HTML DOM elements creation and nesting with attributes/eventListeners etc.
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

  content = content.reduce((a, c) => a.concat(Array.isArray(c) ? c : [c]), []);

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
