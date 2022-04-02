import { deletePet } from '../api/data.js';

export async function deleteView(ctx) {
  const choice = confirm(`Are you sure you want to delete this pet`);
  if (choice) {
    await deletePet(ctx.params.id);
    ctx.page.redirect('/home');
  }
}
