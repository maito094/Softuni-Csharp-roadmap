import { render } from '../node_modules/lit-html/lit-html.js';
import page from '../node_modules/page/page.mjs';

import { navbarView } from './middleWares/navbarUpdate.js';
import { userUpdate } from './middleWares/userStatus.js';
import { catalogView } from './views/catalogView.js';
import { createView } from './views/createView.js';
import { deleteView } from './views/deleteView.js';
import { detailsView } from './views/detailsView.js';
import { editView } from './views/editView.js';
import { homeView } from './views/homeView.js';
import { loginView } from './views/loginView.js';
import { logoutView } from './views/logoutView.js';
import { registerView } from './views/registerView.js';

const root = document.getElementById('main-content');

page(userUpdate);
page(decorateContext);
page(navbarView);

page('/', homeView);
page('/home', homeView);
page('/allGames', catalogView);
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutView);
page('/create', createView);
page('/details/:id', detailsView);
page('/edit/:id', editView);
page('/delete/:id', deleteView);

page.start();

function decorateContext(ctx, next) {
  ctx.render = (content) => render(content, root);
  next();
}
