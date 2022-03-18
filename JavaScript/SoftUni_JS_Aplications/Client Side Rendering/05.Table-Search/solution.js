import { html, render } from '../node_modules/lit-html/lit-html.js';
import { dataRowTemplate } from './dataRowTemplating.js';

const url = 'http://localhost:3030/jsonstore/advanced/table';

let tbody = document.querySelector('tbody');
async function solve() {
  document.querySelector('#searchBtn').addEventListener('click', onClick);

  let dataEntry = await getData();
  update(dataEntry);

  async function onClick() {
    let inputSearch = document.querySelector('#searchField');
    let dataEntry = await getData();
    update(dataEntry, inputSearch.value);
    inputSearch.value='';
  }
}

async function getData() {
  let res = await fetch(url);

  let dataInfo = Object.values(await res.json());

  return dataInfo;
}

function update(dataEntry, match) {
  let allEntries = html`${dataEntry.map((x) => dataRowTemplate(x, match))}`;

  render(allEntries, tbody);
}

solve();
