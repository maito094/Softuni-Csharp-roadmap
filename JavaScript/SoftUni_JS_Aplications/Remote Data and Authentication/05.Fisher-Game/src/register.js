const reginURL = 'http://localhost:3030/users/register';

let welcomeUser = document.querySelector('.email span');
let homeElement = document.getElementById('home');
let registerView = document.getElementById('register-view');
let formRegister = registerView.querySelector('#register');

formRegister.addEventListener('submit', registerUserHandler);


async function registerUserHandler(ev) {
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
  } else if (entry.password != entry.rePass) {
    alert("Passwords doesn't match");
    return;
  } else {
    let res = await fetch(reginURL, {
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

