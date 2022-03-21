import { logout } from './api/api.js';
import { page, render } from './lib.js';
import { getUserData } from './util.js';
import { catalogPage } from './views/catalog.js';
import { createPage } from './views/create.js';
import { detailsPage } from './views/details.js';
import { editPage } from './views/edit.js';
import { loginPage } from './views/login.js';
import { registerPage } from './views/register.js';

const root = document.querySelector('div.container');
document.getElementById('logoutBtn').addEventListener('click', onLogout);
//This decoration function will take the context and attach the needed stuff(dependancy injection)
page(decorateContext); // This will be executed before every other page() with URL.

page('/', catalogPage);
page('/details/:id', detailsPage);
page('/create', createPage);
page('/edit/:id', editPage);
page('/login', loginPage);
page('/register', registerPage);
page('/my-furniture', catalogPage);

updateUserNav();
page.start();

function decorateContext(ctx, next) {
  ctx.render = (content) => render(content, root); // Every Page with URL will have access to this render function, because it will be attach to the ctx (context)
  ctx.updateUserNav = updateUserNav;
  next();
}

function updateUserNav() {
  const userData = getUserData();
  if (userData) {
    document.getElementById('user').style.display = 'inline-block';
    document.getElementById('guest').style.display = 'none';
  } else {
    document.getElementById('user').style.display = 'none';
    document.getElementById('guest').style.display = 'inline-block';
  }
}

// When href="javascript:void(0)" , the event.preventDefault() is not needed
async function onLogout() {
  await logout();
  updateUserNav();
  page.redirect('/'); // When there is only 1 router in the whole application ( meaning singleton), then only then we can call the methods like static
}
