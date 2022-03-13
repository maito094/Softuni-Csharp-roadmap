
import { viewControl } from './viewControl.js';


let homeButton = document.querySelector('a[href="/Home"]');

homeButton.addEventListener('click', (e) => {
  e.preventDefault();

  viewControl('homeView');

  console.log(e.currentTarget);
});

viewControl('homeView');
