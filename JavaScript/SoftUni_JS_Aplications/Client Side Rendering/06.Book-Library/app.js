import { html, render } from '../node_modules/lit-html/lit-html.js';
import { loadBooksTemplate } from './loadBooksTemplating.js';
import { addBookTemplate } from './addBookTemplating.js';
import { editBookTemplate } from './editBookTemplating.js';
import { skeletonTemplate } from './skeletonTemplating.js';
import {
  getBooks,
  getBookById,
  postBooks,
  deleteBook,
  updateBook,
} from './api.service.js';

const body = document.body;

let ctx = {
  editBook: onEditHandler,
  deleteBook: onDeleteHandler,
  onSubmit: onSubmit,
  loadBooks: renderBooks,
  onSave: onSave,
};

window.onload = function init() {
  render(skeletonTemplate(ctx), body);
  renderBooks(false);
};

function update(dataEntries, ctx, editData) {
  let result = html`${dataEntries.map(([k, b]) => {
    ctx['_id'] = k;
    return loadBooksTemplate(b, ctx);
  })}`;

  render(result, document.querySelector('tbody'));
  if (!editData) {
    render(addBookTemplate(ctx), document.querySelector('div'));
  } else {
    render(editBookTemplate(ctx, editData), document.querySelector('div'));
  }
}

async function renderBooks(editData = false) {
  let data = await getBooks();
  update(data, ctx, editData);
}

async function onEditHandler(e) {
  let editData = await getBookById(e.currentTarget.id);
  console.log(editData);

  renderBooks(editData);
}

async function onSubmit(e) {
  e.preventDefault();
  let formData = new FormData(e.currentTarget);

  let postData = {
    author: formData.get('author'),
    title: formData.get('title'),
  };
  e.currentTarget.reset();
  await postBooks(postData);

  await renderBooks(false);
}

async function onSave(e, _id) {
  e.preventDefault();
  let formData = new FormData(e.currentTarget);

  let updateData = {
    author: formData.get('author'),
    title: formData.get('title'),
  };
  e.currentTarget.reset();
  await updateBook(updateData, _id);

  await renderBooks(false);
}

async function onDeleteHandler(e) {
  await deleteBook(e.currentTarget.id);
  await renderBooks(false);
}
