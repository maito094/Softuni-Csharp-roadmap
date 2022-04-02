import { html, render } from '../../node_modules/lit-html/lit-html.js';

let header = document.querySelector('div#box header');

const navbarTemplate = (user) => html` <!-- Navigation -->
  <h1><a class="home" href="/home">GamesPlay</a></h1>
  <nav>
    <a href="/allGames">All games</a>
    ${user
      ? html` <!-- Logged-in users -->
          <div id="user">
            <a href="/create">Create Game</a>
            <a href="/logout">Logout</a>
          </div>`
      : html` <!-- Guest users -->
          <div id="guest">
            <a href="/login">Login</a>
            <a href="/register">Register</a>
          </div>`}
  </nav>`;

export function navbarView(ctx, next) {
  render(navbarTemplate(ctx.user), header);

  next();
}
