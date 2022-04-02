import { deleteItem } from '../api/data.js';

export async function deleteView(ctx) {
  await deleteItem(ctx.params.id);
  ctx.page.redirect('/home');
}
