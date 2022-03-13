import { e, getDateTime } from './util.js';
import { showCommentsInfo } from './comments.js';
import * as request from './requests.js';
import { urls } from './requests.js';
import { viewControl } from './viewControl.js';

let mainContainer = document.querySelector('.container>main'); // TO HIE HOMEPAGE
let topicContent = document.querySelector('.theme-content');
let topicContainer = document.querySelector('.topic-container');
let newTopicElement = document.querySelector('.new-topic-border');

let form = newTopicElement.querySelector('form');
let divButtons = newTopicElement.querySelector('.new-topic-buttons');
divButtons.addEventListener('click', getUserInput);

async function getUserInput(e) {
  e.preventDefault();

  let ev = e.target;

  if (ev.tagName == 'BUTTON') {
    if (ev.className == 'public') {
      let formData = new FormData(form);
      let postText = formData.get('postText');
      let username = formData.get('username');
      let topicName = formData.get('topicName');
      let datetime = getDateTime();
      if (postText && username && topicName) {
        showHomeInfo({ topicName, username, postText, datetime }, true);
      } else {
        alert('Please fill all data inputs');
      }
    }
    form.reset();
  }
}

async function showHomeInfo(dataEntry, post) {
  let info;
  if (post) {
    info = await request.post(dataEntry, urls.topicURL);

    topicContainer.appendChild(createTopic(info));
  } else {
    topicContainer.replaceChildren();
    info = await request.get(urls.topicURL);
    [...Object.values(info)].forEach((x) => {
      topicContainer.appendChild(createTopic(x));
    });
  }
}
function topicDetailView(ev) {
  sessionStorage.setItem('currCommentID', ev.currentTarget.id);
  mainContainer.style.display = 'none';
  topicContent.style.display = 'block';
  showCommentsInfo(ev.currentTarget.id, false);
}
function showTopicComments(ev) {
  console.log(ev.currentTarget.id);

  viewControl('topicView', ev);
}

function createTopic(topicInfo) {
  let topicWrapper = e('div', { className: 'topic-name-wrapper' });
  let resultElement = e(
    'div',
    {
      className: 'topic-name',
      id: `${topicInfo._id}`,
      onClick: showTopicComments,
    },
    [
      e('a', { className: 'normal' }, e('h2', null, `${topicInfo.topicName}`)),
      e('div', { className: 'columns' }, [
        e('div', null, [
          e('p', null, ['Date:', e('time', null, `${topicInfo.datetime}`)]),
          e(
            'div',
            { className: 'nick-name' },
            e('p', null, [
              'Username: ',
              e('span', null, `${topicInfo.username}`),
            ])
          ),
        ]),
      ]),
    ]
  );
  return topicWrapper.appendChild(resultElement);
}

function showHomeView() {
  mainContainer.style.display = 'block';
  topicContent.style.display = 'none';
  sessionStorage.removeItem('currCommentID'); // release the currentClickedTopic' ID,

  showHomeInfo(null, false);
}

export { showHomeView, topicDetailView };
