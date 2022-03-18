import { html } from '../node_modules/lit-html/lit-html.js';

export function editBookTemplate(ctx,ctxEdit) {
  let result = html` <form id="edit-form" @submit=${(e) => ctx.onSave(e,ctxEdit._id)}>
    <input type="hidden" name="id" />
    <h3>Edit book</h3>
    <label>TITLE</label>
    <input type="text" name="title" placeholder="Title..." value=${ctxEdit.title}/>
    <label>AUTHOR</label>
    <input type="text" name="author" placeholder="Author..." value=${ctxEdit.author}/>
    <input type="submit" value="Save" />
  </form>`;

  return result;
}
