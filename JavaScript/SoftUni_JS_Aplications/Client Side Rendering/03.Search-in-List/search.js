import { towns } from './towns.js';
import { html, render } from '../node_modules/lit-html/lit-html.js';
import { classMap } from '../node_modules/lit-html/directives/class-map.js';

let body = document.querySelector('body');

let articleTemplate = html`<article>
  <div id="towns"></div>
  <input type="text" id="searchText" />
  <button @click=${search} active>Search</button>
  <div id="result"></div>
</article>`;

render(articleTemplate, body);
let townsContainer = document.querySelector('#towns');
render(matchTownsTemplate(), townsContainer);
let result = document.getElementById('result');

function update(matchCriterea) {
  let townsFound = matchTownsTemplate(matchCriterea);
  render(html` ${townsFound} `, townsContainer);

  console.log(townsFound);
  result.textContent = `${
    townsFound.values[0].filter((t) => t.values[0].values[0].active == true)
      .length
  } matches found`; // This t=>t.values[0].values[0].active==true is to find just the already active towns
}
function search() {
  let inpText = document.getElementById('searchText');

  update(inpText.value);
}

function matchTownsTemplate(criterea) {
  let _towns = Object.values(towns).map((t) => {
    let isActive;

    if (criterea) {
      isActive = t.toLocaleLowerCase().includes(criterea.toLocaleLowerCase());
    }

    return html`<li class="${classMap({ active: isActive })}">${t}</li>`; //Lector uses Ternary Operator isActive ? 'active' : ''
  });

  return html`<ul>
    ${_towns}
  </ul>`;
}
