import { showView } from './util.js';
import { detailsPage } from './details.js';

const section = document.querySelector('#edit-movie');
const movieEdit = section.querySelector(
  '#edit-movie .text-center.border.border-light.p-5'
);

function editPage(movieId) {
  showView(section);
  displayMovieData(movieId);
}

async function displayMovieData(movieId) {
  let movie = await getMovie(movieId);

  let movieUpdate = {
    title: movie.title,
    description: movie.description,
    img: movie.img,
  };
  let inputs = Array.from(
    movieEdit.querySelectorAll('div .form-group input,textarea')
  );
  Object.values(movieUpdate).forEach((v, i) => {
    inputs[i].value = v;
  });

  movieEdit.addEventListener('submit', (e) => updateMovie(e, movieId));
}

async function getMovie(id) {
  const res = await fetch(`http://localhost:3030/data/movies/${id}`);
  const movie = await res.json();

  return movie;
}

async function updateMovie(e, movieId) {
  e.preventDefault();
  let urlUpdateMovie = 'http://localhost:3030/data/movies';
  const user = JSON.parse(localStorage.getItem('user'));

  let formData = new FormData(movieEdit);
  let title = formData.get('title');
  let description = formData.get('description');
  let img = formData.get('imageUrl');

  urlUpdateMovie += `/${movieId}`;
  if (title && description && img) {
    await fetch(urlUpdateMovie, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
        'X-Authorization': user.accessToken,
      },
      body: JSON.stringify({ title, description, img }),
    });

    detailsPage(movieId);
  } else {
    alert('Inputs must be non-empty');
  }
}
export { editPage };
