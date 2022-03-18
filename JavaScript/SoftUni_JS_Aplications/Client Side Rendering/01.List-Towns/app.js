import { html, render } from '../node_modules/lit-html/lit-html.js';
import { townTemplate } from './townTemplate.js';

let form = document.querySelector('form');
let root = document.getElementById('root');

form.addEventListener('submit', cityHandler);

function cityHandler(e) {
  e.preventDefault();
  let formData = new FormData(e.currentTarget);

  let cities = formData.get('towns').split(', ').filter(x => x !== '');
  console.log(cities);

  
    const townList = html`
      <ul>
        ${cities.map((town) => html`${townTemplate(town)}`)}
      </ul>
    `;

    render(townList, root);
  

  form.reset();
}
