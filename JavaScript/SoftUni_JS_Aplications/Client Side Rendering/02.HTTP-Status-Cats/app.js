// <ul>

import { html, render } from '../node_modules/lit-html/lit-html.js';
import { cats } from './catSeeder.js';
import { catTemplate } from './catTemplate.js';

let allCats = document.getElementById('allCats');

let ulElement = html`<ul>
  ${cats.map((cat) => html`${catTemplate(cat)}`)}
</ul>`;

render(ulElement, allCats);
