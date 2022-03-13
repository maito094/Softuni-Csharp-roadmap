import { showView, updateNav } from './util.js';
import { homePage } from './home.js';

//action="#" method="post"
const section = document.querySelector('#form-sign-up');
const form = document.querySelector(
  '#form-sign-up .text-center.border.border-light.p-5'
);
form.addEventListener('submit', registerUser);
export function registerPage() {
  showView(section);
  console.log(form);
}

async function registerUser(ev) {
  ev.preventDefault();

  let formData = new FormData(ev.currentTarget);
  let [email, password, rePass] = formData.values();
  let dataEntry = { email, password };
  if (email && password && password.length >= 6 && password == rePass) {
    await postUserRegistration(dataEntry);
    updateNav();
    homePage();
  } else {
    alert('Incorrect Data');
  }
}

async function postUserRegistration(dataEntry) {
  try {
    const res = await fetch('http://localhost:3030/users/register', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(dataEntry),
    });
    if (!res.ok) {
      const error = await res.json();
      throw new Error(error.message);
    }

    const user = await res.json();
    localStorage.setItem('user', JSON.stringify(user));
  } catch (err) {
    alert(err.message);
    throw err;
  }
}
