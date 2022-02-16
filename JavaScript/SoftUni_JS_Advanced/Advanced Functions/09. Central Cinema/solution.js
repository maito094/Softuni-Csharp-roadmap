function solve() {
  let btnOnScreen = document.querySelector('#container button');
  let btnclear = document.querySelector('#archive button');

  btnOnScreen.addEventListener('click', addMovie, false);
  btnclear.addEventListener('click', clearArchive);

  function addMovie(e) {
    e.preventDefault();
    let parentDivElement = e.currentTarget.parentElement;
    let nameInputElement = parentDivElement.querySelector(
      'input[placeholder="Name"]',
    );
    let hallInputElement = parentDivElement.querySelector(
      'input[placeholder="Hall"]',
    );
    let ticketPriceElement = parentDivElement.querySelector(
      'input[placeholder="Ticket Price"]',
    );
    let ticketPrice=ticketPriceElement.value;
    let ulMoviesElement = document.querySelector('#movies ul');

    if (
      nameInputElement.value &&
      hallInputElement.value &&
      ticketPrice !== '' &&
      ticketPrice >= 0
    ) {
      let liElement = document.createElement('li');
      let spanEl = document.createElement('span');
      spanEl.textContent = nameInputElement.value;
      let strongEl = document.createElement('strong');
      strongEl.textContent = `Hall: ${hallInputElement.value}`;
      liElement.appendChild(spanEl);
      liElement.appendChild(strongEl);

      let divEl = document.createElement('div');
      let strongDivEl = document.createElement('strong');
      strongDivEl.textContent = Number(ticketPrice).toFixed(2);
      let inpEl = document.createElement('input');
      inpEl.setAttribute('placeholder', 'Tickets Sold');
      let btnArchive = document.createElement('button');
      btnArchive.textContent = 'Archive';

      btnArchive.addEventListener('click', archive);

      divEl.appendChild(strongDivEl);
      divEl.appendChild(inpEl);
      divEl.appendChild(btnArchive);

      liElement.appendChild(divEl);
      ulMoviesElement.appendChild(liElement);
      // console.log(liElement);

      nameInputElement.value='';
      hallInputElement.value='';
      ticketPriceElement.value='';
    }
  }
  function archive(e) {
    let currentMovieDiv = e.currentTarget.parentElement;
    let liMovie = currentMovieDiv.parentElement;
    let ticketPrice = Number(currentMovieDiv.querySelector('strong').textContent);

    let ticketSold = currentMovieDiv.querySelector(
      'input[placeholder="Tickets Sold"]',
    ).value;

    if (ticketSold !== '' && ticketSold >= 0) {
      let archiveSection_ul = document.querySelector('#archive ul');

      let liElement = document.createElement('li');
      let spanEl = document.createElement('span');
      spanEl.textContent = liMovie.querySelector('span').textContent;
      liElement.appendChild(spanEl);

      let strongEl = document.createElement('strong');
      strongEl.textContent = `Total amount: ${(
        ticketPrice * Number(ticketSold)
      ).toFixed(2)}`;
      liElement.appendChild(strongEl);

      let delBtn = document.createElement('button');
      delBtn.textContent = 'Delete';
      delBtn.addEventListener('click', deleteArhive);
      liElement.appendChild(delBtn);

      liMovie.remove();
      archiveSection_ul.appendChild(liElement);
    }
  }

  function deleteArhive(e) {
    let parentliElement = e.currentTarget.parentElement;
    parentliElement.remove();
  }

  function clearArchive(e) {
    let parent_ul = e.currentTarget.parentElement;

    let liElements = parent_ul.getElementsByTagName('li');

    while (liElements.length > 0) {
      liElements[0].remove();
    }
  }
}
