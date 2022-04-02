import { html } from '../../node_modules/lit-html/lit-html.js';
import { nothing } from '../../node_modules/lit-html/lib/part.js';
import { getById, getDonations, getOwnDonations } from '../api/data.js';

const detailsTemplate = (
  user,
  pet,
  donations,
  hasDonated
) => html`<!--Details Page-->
  <section id="detailsPage">
    <div class="details">
      <div class="animalPic">
        <img src=${pet.image} />
      </div>
      <div>
        <div class="animalInfo">
          <h1>Name: ${pet.name}</h1>
          <h3>Breed: ${pet.breed}</h3>
          <h4>Age: ${pet.age}</h4>
          <h4>Weight: ${pet.weight}</h4>
          <h4 class="donation">Donation: ${donations}$</h4>
        </div>
        ${user
          ? html` <!-- if there is no registered user, do not display div-->
              <div class="actionBtn">
                <!-- Only for registered user and creator of the pets-->
                ${user.id == pet._ownerId
                  ? html`<a href="/edit/${pet._id}" class="edit">Edit</a>
                      <a href="/delete/${pet._id}" class="remove">Delete</a>`
                  : hasDonated
                  ? nothing
                  : html`<!--(Bonus Part) Only for no creator and user-->
                      <a href="/donate/${pet._id}" class="donate">Donate</a>`}
              </div>`
          : nothing}
      </div>
    </div>
  </section>`;

export async function detailsView(ctx) {
  const pet = await getById(ctx.params.id);
  let donations = await getDonations(ctx.params.id);
  donations *= 100;
  let hasDonated;
  if (ctx.user) {
    hasDonated = await getOwnDonations(ctx.params.id, ctx.user.id);
    hasDonated > 0 ? (hasDonated = true) : (hasDonated = false);
  }

  ctx.render(detailsTemplate(ctx.user, pet, donations, hasDonated));
}
