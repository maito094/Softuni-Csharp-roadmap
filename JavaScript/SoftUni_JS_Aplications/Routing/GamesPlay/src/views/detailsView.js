import { html } from '../../node_modules/lit-html/lit-html.js';
import { nothing } from '../../node_modules/lit-html/lib/part.js';
import { createComment, getById, getComments } from '../api/data.js';
import { createSubmitHandler } from '../util.js';

const detailsTemplate = (user, game, comments, onSubmit) => html`
  <!--Details Page-->
  <section id="game-details">
    <h1>Game Details</h1>
    <div class="info-section">
      <div class="game-header">
        <img class="game-img" src=${game.imgUrl} />
        <h1>${game.title}</h1>
        <span class="levels">MaxLevel: ${game.maxLevel}</span>
        <p class="type">${game.category}</p>
      </div>

      <p class="text">${game.summary}</p>

      <!-- Bonus ( for Guests and Users ) -->
      <div class="details-comments">
        <h2>Comments:</h2>
        ${comments.length > 0
          ? html`<ul>
              <!-- list all comments for current game (If any) -->
              ${comments.map((c) => commentTemplate(c.comment))}
            </ul>`
          : html`<!-- Display paragraph: If there are no games in the database -->
              <p class="no-comment">No comments.</p>`}
      </div>

      <!-- Edit/Delete buttons ( Only for creator of this game )  -->
      ${user && user.id == game._ownerId
        ? html`<div class="buttons">
            <a href="/edit/${game._id}" class="button">Edit</a>
            <a href="/delete/${game._id}" class="button">Delete</a>
          </div>`
        : nothing}
    </div>

    <!-- Bonus -->
    <!-- Add Comment ( Only for logged-in users, which is not creators of the current game ) -->
    ${user && user.id != game._ownerId
      ? html` <article class="create-comment">
          <label>Add new comment:</label>
          <form class="form" @submit=${onSubmit}>
            <textarea name="comment" placeholder="Comment......"></textarea>
            <input class="btn submit" type="submit" value="Add Comment" />
          </form>
        </article>`
      : nothing}
  </section>
`;

const commentTemplate = (comment) => html`<li class="comment">
  <p>Content: ${comment}</p>
</li>`;

export async function detailsView(ctx) {
  const game = await getById(ctx.params.id);
  const commentsObj = await getComments(ctx.params.id);
  //   const { comments } = commentsObj;
  console.log(commentsObj);
  ctx.render(
    detailsTemplate(
      ctx.user,
      game,
      commentsObj,
      createSubmitHandler(ctx, onSubmit)
    )
  );

  async function onSubmit(ctx, data, event) {
    if (!data.comment) {
      alert('missing data entries');
      return;
    }
    const comment = {
      gameId: ctx.params.id,
      comment: data.comment,
    };
    await createComment(comment);
    event.target.reset();
    ctx.page.redirect(`/details/${comment.gameId}`);
  }
}
