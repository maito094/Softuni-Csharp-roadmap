import { showHomeView, topicDetailView } from './home.js';
//import {  } from './comments.js';

let page = {
  homeView: showHomeView,
  topicView: topicDetailView,
};

function viewControl(path, ev) {
  if (typeof page[path] === 'function') {
    let view;
    view = page[path];
    ev ? view(ev) : view();
  }
}

export { viewControl };
