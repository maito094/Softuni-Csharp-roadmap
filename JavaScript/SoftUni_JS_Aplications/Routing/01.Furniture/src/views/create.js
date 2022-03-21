import { createItem } from '../api/data.js';
import { html } from '../lib.js';

const inputRange = {
  make: (v) => v.length < 4,
  model: (v) => v.length < 4,
  year: (v) => Number(v) <= 1950 || Number(v) >= 2050,
  description: (v) => v.length <= 10,
  price: (v) => Number(v) < 0,
  img: (v) => !v,
};

const createTemplate = (onSubmit, errorMsg, errors) => html`<div
    class="row space-top"
  >
    <div class="col-md-12">
      <h1>Create New Furniture</h1>
      <p>Please fill all fields.</p>
      ${errorMsg ? html`<div class="form-group error">${errorMsg}</div>` : null}
    </div>
  </div>
  <form @submit=${onSubmit}>
    <div class="row space-top">
      <div class="col-md-4">
        <div class="form-group">
          <label class="form-control-label" for="new-make">Make</label>
          <input
            class=${'form-control' + (errors.make ? ' is-invalid' : '')}
            id="new-make"
            type="text"
            name="make"
          />
        </div>
        <div class="form-group">
          <label class="form-control-label" for="new-model">Model</label>
          <input
            class=${'form-control' + (errors.model ? ' is-invalid' : '')}
            id="new-model"
            type="text"
            name="model"
          />
        </div>
        <div class="form-group">
          <label class="form-control-label" for="new-year">Year</label>
          <input class="${'form-control' + (errors.year ? ' is-invalid' : '')}
          id ="new-year" type="number" name="year" />
        </div>
        <div class="form-group">
          <label class="form-control-label" for="new-description"
            >Description</label
          >
          <input
            class=${'form-control' + (errors.description ? ' is-invalid' : '')}
            id="new-description"
            type="text"
            name="description"
          />
        </div>
      </div>
      <div class="col-md-4">
        <div class="form-group">
          <label class="form-control-label" for="new-price">Price</label>
          <input
            class=${'form-control' + (errors.price ? ' is-invalid' : '')}
            id="new-price"
            type="number"
            name="price"
          />
        </div>
        <div class="form-group">
          <label class="form-control-label" for="new-image">Image</label>
          <input
            class=${'form-control' + (errors.img ? ' is-invalid' : '')}
            id="new-image"
            type="text"
            name="img"
          />
        </div>
        <div class="form-group">
          <label class="form-control-label" for="new-material"
            >Material (optional)</label
          >
          <input
            class="form-control"
            id="new-material"
            type="text"
            name="material"
          />
        </div>
        <input type="submit" class="btn btn-primary" value="Create" />
      </div>
    </div>
  </form>`;

export function createPage(ctx) {
  ctx.render(createTemplate(onSubmit, null, {}));

  async function onSubmit(event) {
    event.preventDefault();
    const formData = [...new FormData(event.target).entries()];
    const data = formData.reduce(
      (a, [k, v]) => Object.assign(a, { [k]: v.trim() }),
      {}
    );

    const missing = formData.filter(
      ([k, v]) => k != 'material' && v.trim() == ''
    );
    const invalidInputs = formData.filter(
      ([k, v]) => k != 'material' && inputRange[k](v.trim())
    );
    try {
      if (missing.length > 0) {
        const errors = missing.reduce(
          (a, [k]) => Object.assign(a, { [k]: true }),
          {}
        );
        console.log(errors);
        throw {
          error: new Error('Please fill all mandatory fields'),
          errors,
        };
      }
      if (invalidInputs.length > 0) {
        const errors = invalidInputs.reduce(
          (a, [k]) => Object.assign(a, { [k]: true }),
          {}
        );
        console.log(errors);
        throw {
          error: new Error('Please fill all mandatory fields with valid data'),
          errors,
        };
      }

      data.year = Number(data.year);
      data.price = Number(data.price);

      // MAKE A DATA VALIDATION FOR EVERY VARIABLE INPUT HERE BEFORE DOING REQUESTS
      const result = await createItem(data);
      event.target.reset();
      ctx.page.redirect('/details/' + result._id);
    } catch (error) {
      const message = error.message || error.error.message;
      ctx.render(createTemplate(onSubmit, message, error.errors || {}));
    }
  }
}
