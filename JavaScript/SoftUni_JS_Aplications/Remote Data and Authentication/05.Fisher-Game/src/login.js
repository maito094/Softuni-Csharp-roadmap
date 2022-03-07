const loginURL = 'http://localhost:3030/users/login';

let welcomeUser = document.querySelector('.email span');
let loginView = document.getElementById('login-view');
let loginForm = loginView.querySelector('#login');

loginForm.addEventListener('submit', loginUserHandler);



async function loginUserHandler(ev) {
  ev.preventDefault();

  let formData = new FormData(ev.currentTarget);

  let entry = [...formData.entries()].reduce(
    (p, [k, v]) => Object.assign(p, { [k]: v }),
    {}
  );

  if (!entry.email) {
    alert('Please fill email !');
    return;
  } else if (!entry.password) {
    alert('Please fill password !');
    return;
  } else {
    let res = await fetch(loginURL, {
      method: 'POST',
      headers: { 'content-type': 'application/json' },
      body: JSON.stringify(entry),
    });

    let data = await res.json();

    if (res.status != 200) {
      sessionStorage.clear();
      alert(data.message);
      return;
    }

    sessionStorage.setItem('user', JSON.stringify(data));
    console.log(sessionStorage.getItem('user'));
  }

  routePageURL('index.html');
}

function routePageURL(nextLocation) {
  //console.log(window.location.href);
  let currentURL = window.location.href;
  //console.log(currentURL);

  currentURL = currentURL.split('/');
  currentURL[currentURL.length - 1] = nextLocation;
  currentURL = currentURL.join('/');

  window.location.href = currentURL;
}


