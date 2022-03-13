const baseURL = 'http://localhost:3030/jsonstore/collections/myboard/';

let urls = {
  topicURL: baseURL + 'posts',
  commentsURL: baseURL + 'comments',
};

async function post(dataEntry, url) {
  let res = await fetch(url, {
    method: 'POST',
    Headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(dataEntry),
  });

  let data = await res.json();

  return data;
}

async function get(url) {
  let res = await fetch(url);
  let data = undefined;
  if (res.status == 200) {
    data = await res.json();
  }

  return data;
}

export { post, get, urls };
