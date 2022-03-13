import { e, createComment, showTopic, getDateTime } from './util.js';
import * as request from './requests.js';
import { urls } from './requests.js';

let mainContainer = document.querySelector('.container>main');
let topicContent = document.querySelector('.theme-content');
let commentElement = document.querySelector('.comment');
let topicNameEl = topicContent.querySelector('.theme-name>h2');

let form = document.querySelector('.answer>form');
form.addEventListener('submit', addComment);


function addComment(ev) {
  ev.preventDefault();
  let topicName = topicNameEl.textContent;
  let id = sessionStorage.getItem('currCommentID');
  let formData = new FormData(form);
  let username = formData.get('username');
  let postText = formData.get('postText');
  let datetime = getDateTime();
  if (username && postText) {
    showCommentsInfo({ topicName, username, postText, datetime, id }, true);
  } else {
    alert('Please fill all data inputs');
  }

  form.reset();
}



async function showCommentsInfo(dataEntry, post) {
  let info;
  if (post) {
    info = await request.post(dataEntry, urls.commentsURL);

    commentElement.appendChild(createComment(info));
  } else {
    let id = dataEntry;
    commentElement.innerHTML = '<div id="user-comment"></div>';
    info = await request.get(urls.topicURL);

    commentElement.appendChild(showTopic(info[id]));

    topicNameEl.textContent = info[id].topicName;

    let infoComments = await request.get(urls.commentsURL);

    if (infoComments) {
      [...Object.values(infoComments)].forEach((x) => {
        // Appending only comments that are with the same ID as the Topic's
        if (x.id == info[id]._id) {
          commentElement.appendChild(createComment(x));
        }
      });
    }
  }
}

export { showCommentsInfo };
