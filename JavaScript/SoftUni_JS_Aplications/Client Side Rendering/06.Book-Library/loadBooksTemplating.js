import { html } from '../node_modules/lit-html/lit-html.js';

export function loadBooksTemplate(dataIn, ctx) {
  let result = html` <tr>
    <td>${dataIn.title}</td>
    <td>${dataIn.author}</td>
    <td>
      <button id=${ctx._id} @click=${(e) => ctx.editBook(e)}>Edit</button>
      <button id=${ctx._id} @click=${(e) => ctx.deleteBook(e)}>Delete</button>
    </td>
  </tr>`;

  return result;
}
