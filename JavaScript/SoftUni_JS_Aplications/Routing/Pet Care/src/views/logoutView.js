import { logout } from '../api/api.js';

export async function logoutView(ctx) {
  await logout();
  ctx.page.redirect('/home');
}
