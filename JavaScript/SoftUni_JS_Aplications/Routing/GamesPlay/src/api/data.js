import * as api from './api.js';

// export const login = api.login;
// export const register = api.register;
// export const logout = api.logout;

const endpoints = {
  all: '/data/games?sortBy=_createdOn%20desc',
  allDistinct: '/data/games?sortBy=_createdOn%20desc&distinct=category',
  byId: '/data/games/',
  gameComments: (gameId) => `/data/comments?where=gameId%3D%22${gameId}%22`,
  createComment: '/data/comments',
  create: '/data/games',
  edit: '/data/games/',
  delete: '/data/games/',
};
// export functionality with request which are specific for this Application
export async function getAll() {
  return api.get(endpoints.all);
}
// export functionality with request which are specific for this Application
export async function getAllDistinct() {
  return api.get(endpoints.allDistinct);
}

export async function getById(id) {
  return api.get(endpoints.byId + id);
}
export async function getComments(gameId) {
  return api.get(endpoints.gameComments(gameId));
}

export async function createItem(data) {
  return api.post(endpoints.create, data);
}

export async function createComment(data) {
  return api.post(endpoints.createComment, data);
}

export async function editItem(id, data) {
  return api.put(endpoints.edit + id, data);
}

export async function deleteItem(id) {
  return api.del(endpoints.delete + id);
}
