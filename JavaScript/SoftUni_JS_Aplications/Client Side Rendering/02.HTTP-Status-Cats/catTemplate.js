import { html } from '../node_modules/lit-html/lit-html.js';

function catTemplate(cat) {
  return html`
    <li>
      <img
        src="./images/${cat.imageLocation}.jpg"
        width="250"
        height="250"
        alt="Card image cap"
      />
      <div class="info">
        <button
          @click="${(e) => {
            if (e.currentTarget.textContent == 'Show status code') {
              e.currentTarget.textContent = 'Hide status code';
              e.currentTarget.parentElement.querySelector(
                '.status'
              ).style.display = 'block';
            } else {
              e.currentTarget.textContent = 'Show status code';
              e.currentTarget.parentElement.querySelector(
                '.status'
              ).style.display = 'none';
            }
          }}"
          class="showBtn"
        >Show status code</button>
        <div class="status" style="display: none" id=${cat.id}>
          <h4>Status Code: ${cat.statusCode}</h4>
          <p>${cat.statusMessage}</p>
        </div>
      </div>
    </li>
  `;
}


export { catTemplate };
