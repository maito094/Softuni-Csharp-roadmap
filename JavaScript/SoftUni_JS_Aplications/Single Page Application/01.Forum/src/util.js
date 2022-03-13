
function showTopic(topicInfo) {
  let { topicName, username, postText, datetime, _id } = topicInfo;

  let header = e('div', { className: 'header' }, [
    e('img', { src: './static/profile.png', alt: 'avatar' }),
    e('p', null, [
      e('span', null, username),
      ' posted on ',
      e('time', null, datetime),
    ]),
    e('p',{className:'post-content'},postText)
  ]);

  return header;

}

function createComment(commentInfo) {
  let { topicName, username, postText, datetime, id } = commentInfo;
  let header = e('h2', null, `${topicName}`);
  let topicNameWrapper = e('div', { className: 'topic-name-wrapper' });
  let resultElement = e('div', {id:id, className: 'topic-name' }, [
    e('p', null, [
      e('strong', null, `${username}`),
      ' commented on ',
      e('time', null, `${datetime}`),
    ]),
    e('div', { className: 'post-content' }, e('p', null, `${postText}`)),
  ]);

  return header.appendChild(topicNameWrapper.appendChild(resultElement));
}
// Improve to add input argument for Delimeters characters
function getDateTime() {
  let currentdate = new Date();
  let datetime =
    currentdate.getFullYear() +
    '-' +
    (currentdate.getMonth() + 1) +
    '-' +
    currentdate.getDate() +
    'T' +
    currentdate.getHours() +
    ':' +
    currentdate.getMinutes() +
    ':' +
    currentdate.getSeconds() +
    'Z';

  return datetime;
}

function e(type, attributes, ...content) {
  const result = document.createElement(type);

  for (let [attr, value] of Object.entries(attributes || {})) {
    if (attr.substring(0, 2) == 'on') {
      result.addEventListener(attr.substring(2).toLocaleLowerCase(), value);
    } else {
      if (value === '') {
        result.setAttribute(attr, '');
      } else {
        result[attr] = value;
      }
    }
  }

  content = content.reduce((a, c) => a.concat(Array.isArray(c) ? c : [c]), []);

  content.forEach((e) => {
    if (typeof e == 'string' || typeof e == 'number') {
      const node = document.createTextNode(e);
      result.appendChild(node);
    } else {
      result.appendChild(e);
    }
  });

  return result;
}

export {  createComment, showTopic, e, getDateTime };
