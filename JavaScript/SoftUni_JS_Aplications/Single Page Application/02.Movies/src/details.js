import { homePage } from './home.js';
import { editPage } from './edit.js';
import { showView, spinner } from './util.js';

const section = document.querySelector('#movie-example');

export function detailsPage(id) {
  showView(section);
  displayMovie(id);
}

async function displayMovie(id) {
  section.replaceChildren(spinner());

  const user = JSON.parse(localStorage.getItem('user'));

  const [movie, likes, ownLike] = await Promise.all([
    getMovie(id),
    getLikes(id),
    getOwnLike(id, user),
  ]);
  //console.log(ownLike);
  section.replaceChildren(createMovieCard(movie, user, likes, ownLike));
}

function createMovieCard(movie, user, likes, ownLike) {
  const element = document.createElement('div');
  element.className = 'container';
  element.innerHTML = `
    <div class="row bg-light text-dark">
        <h1>Movie title: ${movie.title}</h1>

        <div class="col-md-8">
            <img class="img-thumbnail" src="${movie.img}" alt="Movie">
        </div>
        <div class="col-md-4 text-center">
            <h3 class="my-3 ">Movie Description</h3> 
            <p>${movie.description}</p>
            ${createControls(movie, user, ownLike)}
            <span class="enrolled-span">Liked ${likes}</span>
        </div>
    </div>`;

  const likeBtn = element.querySelector('.like-btn'); // DELETE A LIKE ALOS SHOULD BE ADDED
  if (likeBtn) {
    likeBtn.addEventListener('click', (e) => likeMovie(e, movie._id, ownLike));
  }
  const deleteBtn = element.querySelector('.btn.btn-danger');
  if (deleteBtn) {
    
    deleteBtn.addEventListener('click', (e) => deleteMovie(e, movie._id));
  }
  const editBtn = element.querySelector('.btn.btn-warning');
  if (editBtn) {
    editBtn.addEventListener('click', (e) => editPage(movie._id));
    
  }

  return element;
}

function createControls(movie, user, ownLike) {
  const isOwner = user && user._id == movie._ownerId;

  let controls = [];

  if (isOwner) {
    controls.push('<a class="btn btn-danger" href="#">Delete</a>');
    controls.push('<a class="btn btn-warning" href="#">Edit</a>');
  } else if (user && ownLike.length == 0) {
    // == false
    controls.push('<a class="btn btn-primary like-btn" href="#">Like</a>');
  } else if (user && ownLike.length > 0) {
    controls.push('<a class="btn btn-primary like-btn" href="#">Dislike</a>');
  }
  controls.push();

  return controls.join('');
}

async function getMovie(id) {
  const res = await fetch(`http://localhost:3030/data/movies/${id}`);
  const movie = await res.json();

  return movie;
}

async function getLikes(id) {
  const res = await fetch(
    `http://localhost:3030/data/likes?where=movieId%3D%22${id}%22&distinct=_ownerId&count`
  );
  const likes = await res.json();

  return likes;
}

async function getOwnLike(movieId, user) {
  if (!user) {
    return {};
  } else {
    const userId = user._id;
    const res = await fetch(
      `http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22%20and%20_ownerId%3D%22${userId}%22`
    );
    const like = await res.json();
    console.log(like);
    return like; //.length > 0;
  }
}

async function likeMovie(e, movieId, ownLike) {
  e.preventDefault();
  let urlLikes = 'http://localhost:3030/data/likes';

  const user = JSON.parse(localStorage.getItem('user'));
  console.log(e.currentTarget.textContent);
  //console.log(ownLike[0]._id);
  if (e.currentTarget.textContent == 'Dislike') {
    urlLikes += `/${ownLike[0]._id}`;
    await fetch(urlLikes, {
      method: 'DELETE',
      headers: {
        'Content-Type': 'application/json',
        'X-Authorization': user.accessToken,
      },
    });
  } else {
    await fetch(urlLikes, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'X-Authorization': user.accessToken,
      },
      body: JSON.stringify({
        movieId,
      }),
    });
  }

  detailsPage(movieId);
}

async function deleteMovie(e,movieId) {

  let urlDelete = `http://localhost:3030/data/movies/${movieId}`;
  const user = JSON.parse(localStorage.getItem('user'));

    await fetch(urlDelete, {
      method: 'DELETE',
      headers: {
        'Content-Type': 'application/json',
        'X-Authorization': user.accessToken,
      },
    });


    homePage();
}
