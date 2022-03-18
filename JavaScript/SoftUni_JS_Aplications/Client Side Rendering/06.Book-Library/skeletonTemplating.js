import { html } from '../node_modules/lit-html/lit-html.js';

export function skeletonTemplate(ctx) {
  return html` <button @click=${()=>ctx.loadBooks(false)} id="loadBooks">LOAD ALL BOOKS</button>
    <table>
      <thead>
        <tr>
          <th>Title</th>
          <th>Author</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody></tbody>
    </table>
    <div>

    </div>`;
}

// Div container was added, so that the templating logic stays consistent when changing between add-form, and edit-form , and easier to implement
