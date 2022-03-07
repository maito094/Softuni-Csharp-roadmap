const baseUrl = 'http://localhost:3030/jsonstore/messenger';

const messages = document.getElementById('messages');

const submitBtn = document.getElementById('submit');
const refreshBtn = document.getElementById('refresh');

const userInputMsg = document.querySelector('input[name="content"]');
const userInputAuthor = document.querySelector('input[name="author"]');


function attachEvents() {
  submitBtn.addEventListener('click', postMessageHandler);
  refreshBtn.addEventListener('click', loadMessageHandler);
}

async function postMessageHandler(ev) {
  const content = userInputMsg.value;
  const author = userInputAuthor.value;

  if (!content || !author) {
    return;
  }

  const data = {
    author,
    content,
  };

  let response = await fetch(baseUrl, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(data),
  });

  userInputMsg.value = '';
  userInputAuthor.value = '';
}

async function loadMessageHandler(ev) {
  messages.textContent = '';
  const res = await fetch(baseUrl);
  const data = await res.json();

   messages.value = Object.values(data).map(({author,content})=>`${author}: ${content}`).join('\n');

//   messagesInfo.forEach(
//     (m) => (messages.textContent += `${m.author}: ${m.content}\n`)
//   );
}

attachEvents();
