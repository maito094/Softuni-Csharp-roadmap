
import page from '../node_modules/page/page.mjs';
import { decorateContext } from './middleWares/decorateContext.js';

import { navbarView } from './middleWares/navbarUpdate.js';
import { userUpdate } from './middleWares/userStatus.js';
import { homeView } from './views/homeView.js';
import { loginView } from './views/loginView.js';
import { logoutView } from './views/logoutView.js';
import { registerView } from './views/registerView.js';
import { dashboardView } from './views/dashboardView.js';
import { createView } from './views/createView.js';
import { detailsView } from './views/detailsView.js';
import { editView } from './views/editView.js';
import { deleteView } from './views/deleteView.js';
import { donateView } from './views/donateView.js';

page(userUpdate);
page(decorateContext);
page(navbarView);

page('/home', homeView);
page('/', homeView);
page('/dashboard', dashboardView);
page('/login', loginView);
page('/register', registerView);
page('/create', createView);
page('/logout', logoutView);
page('/details/:id', detailsView);
page('/edit/:id', editView);
page('/delete/:id', deleteView);
page('/donate/:id', donateView);

page.start();

