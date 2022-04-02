import { html, render } from '../../node_modules/lit-html/lit-html.js';

let header = document.querySelector('header');

const navbarTemplate = (user) => html`<nav>
  <section class="logo">
    <img src="./images/logo.png" alt="logo" />
  </section>
  <ul>
    <!--Users and Guest-->
    <li><a href="/home">Home</a></li>
    <li><a href="/dashboard">Dashboard</a></li>
    ${!user
      ? html`<!--Only Guest-->
          <li><a href="/login">Login</a></li>
          <li><a href="/register">Register</a></li>`
      : html`<!--Only Users-->
          <li><a href="/create">Create Postcard</a></li>
          <li><a href="/logout">Logout</a></li>`}
  </ul>
</nav>`;

export function navbarView(ctx, next) {
  render(navbarTemplate(ctx.user), header);

  next();
}
