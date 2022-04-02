import * as api from './api.js';

const endpoints = {
  register: '/users/register',
  login: '/users/login',
  logout: '/users/logout',
  catalog: '/data/pets?sortBy=_createdOn%20desc&distinct=name',
  create: '/data/pets',
  donation: '/data/donation',
  details: (id) => `/data/pets/${id}`,
  edit: (id) => `/data/pets/${id}`,
  delete: (id) => `/data/pets/${id}`,
  total: (petId) => `/data/donation?where=petId%3D%22${petId}%22&distinct=_ownerId&count`,
  own: (petId, userId) => `/data/donation?where=petId%3D%22${petId}%22%20and%20_ownerId%3D%22${userId}%22&count`
};

export async function getPets() {
  return api.get(endpoints.catalog);
}

export async function getById(id) {
  return api.get(endpoints.details(id));
}
export async function getDonations(id) {
  return api.get(endpoints.total(id));
}

export async function getOwnDonations(id,userId) {
  return api.get(endpoints.own(id,userId));
}

export async function createPet(data) {
  return api.post(endpoints.create, data);
}

export async function donate(data) {
  return api.post(endpoints.donation,data);
}

export async function editPet(id, data) {
  return api.put(endpoints.edit(id),data);
}

export async function deletePet(id) {
  return api.del(endpoints.delete(id));
}
