import { donate } from '../api/data.js';

export async function donateView(ctx) {
  const petId = ctx.params.id;
  await donate({ petId });

  ctx.page.redirect('/details/' + ctx.params.id);
}
