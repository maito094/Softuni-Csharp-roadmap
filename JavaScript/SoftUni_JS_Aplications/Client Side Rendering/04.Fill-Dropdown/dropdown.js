import { html, render } from '../node_modules/lit-html/lit-html.js';
import { classMap } from '../node_modules/lit-html/directives/class-map.js';

const url = 'http://localhost:3030/jsonstore/advanced/dropdown';

let main = document.querySelector('div');
let form = document.querySelector('form');
form.addEventListener('submit', addItem);
const options = await getOptions();

function selectTemplate(data) {
  return html`<select id="menu">
    ${data.map((el) => html`<option value=${el._id}>${el.text}</option>`)}
  </select>`;
}

update(options);

function update(options) {
  const result = selectTemplate(options);
  render(result, main);
}

async function addItem(e) {
  e.preventDefault();
  let formData = new FormData(e.currentTarget);
  let text = formData.get('text');
  if (!text) {
    alert('please fill text');
    return;
  }
  options.push(await postOption(text));

  // let data = await getOptions(); No need to fetch again the data from server, just push the response of the New Entry
  update(options);
  form.reset();
}

async function postOption(text) {
  const response = await fetch(url, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ text }),
  });

  const data = await response.json();
  console.log(data);
  return data;
}

async function getOptions() {
  const response = await fetch(url);

  const data = await response.json();

  console.log(data);
  return Object.values(data);
}
