import { html } from '../../node_modules/lit-html/lit-html.js';
import { login } from '../api/api.js';
import { createSubmitHandler } from '../util.js';

const loginTemplate = (onSubmit) => html` <!--Login Page-->
  <section id="loginPage">
    <form class="loginForm" @submit=${onSubmit}>
      <img src="./images/logo.png" alt="logo" />
      <h2>Login</h2>

      <div>
        <label for="email">Email:</label>
        <input
          id="email"
          name="email"
          type="text"
          placeholder="steven@abv.bg"
          value=""
        />
      </div>

      <div>
        <label for="password">Password:</label>
        <input
          id="password"
          name="password"
          type="password"
          placeholder="********"
          value=""
        />
      </div>

      <button class="btn" type="submit">Login</button>

      <p class="field">
        <span
          >If you don't have profile click <a href="/register">here</a></span
        >
      </p>
    </form>
  </section>`;

export function loginView(ctx) {
  console.log(ctx);
  ctx.render(loginTemplate(createSubmitHandler(ctx, onSubmit)));

  async function onSubmit(ctx, data, event) {
    if (!data.email || !data.password) {
      alert('missing data entries');
      return;
    }
    await login(data.email, data.password);
    event.target.reset();
    ctx.page.redirect('/home');
  }
}
