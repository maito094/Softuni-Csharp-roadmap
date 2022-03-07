function getBookCollection() {
  const baseURL = 'http://localhost:3030/jsonstore/collections/books';

  let loadBooksBtn = document.getElementById('loadBooks');
  let tbody = document.querySelector('tbody');
  let form = document.querySelector('form');
  let inputAuthor = form.querySelector('input[name="author"]');
  let inputTitle = form.querySelector('input[name="title"]');
  let h3 = form.getElementsByTagName('h3')[0];
  let confirmBtn = form.getElementsByTagName('button')[0];

  // COULD USE SOME CODE REFACTORING.
  confirmBtn.addEventListener('click', executeCommandHandler);

  loadBooksBtn.addEventListener('click', onClickLoadLibrary);

  async function onClickLoadLibrary() {
    tbody.replaceChildren();
    const res = await fetch(baseURL);
    const data = await res.json();

    Object.entries(data).map(([id, { author, title }]) => {
      let result = e('tr', { id: id }, [
        e('td', null, title),
        e('td', null, author),
        e('td', null, [
          e('button', { onClick: onEditHandler }, 'Edit'),
          e('button', { onClick: onDeleteHandler }, 'Delete'),
        ]),
      ]);

      tbody.appendChild(result);
    });
  }

  async function executeCommandHandler(ev) {
    ev.preventDefault();
    let author = inputAuthor.value;
    let title = inputTitle.value;

    currentEntry = {
      author,
      title,
    };

    if (!author || !title) {
      return;
    }

    if (confirmBtn.textContent == 'Submit') {
      let res = await fetch(baseURL, {
        method: 'POST',
        headers: { 'Content-Type': 'aplication/json' },
        body: JSON.stringify(currentEntry),
      });

      let data = await res.json();

      tbody.appendChild(
        e('tr', { id: data._id }, [
          e('td', null, title),
          e('td', null, author),
          e('td', null, [
            e('button', { onClick: onEditHandler }, 'Edit'),
            e('button', { onClick: onDeleteHandler }, 'Delete'),
          ]),
        ])
      );
    } else if (confirmBtn.textContent == 'Save') {
      let res = await fetch(baseURL + `/${confirmBtn.id}`, {
        method: 'PUT',
        headers: { 'Content-Type': 'multipart/form-data' },
        body: JSON.stringify(currentEntry),
      });

      let currentEditEntry = document.getElementById(`${confirmBtn.id}`);
      let tdContents = currentEditEntry.querySelectorAll('td');
      tdContents[0].innerText = title;
      tdContents[1].innerText = author;
      h3.textContent = 'FORM';
      confirmBtn.textContent = 'Submit';
      confirmBtn.id = '';
    }

    inputAuthor.value = '';
    inputTitle.value = '';
  }

  function onEditHandler(ev) {
    let trData = ev.currentTarget.parentElement.parentElement;

    let tdContents = trData.querySelectorAll('td');

    if (confirmBtn.textContent == 'Save' && confirmBtn.id == trData.id) {
      inputTitle.value = '';
      inputAuthor.value = '';
      h3.textContent = `FORM`;
      confirmBtn.textContent = 'Submit';
      confirmBtn.id = '';
    } else {
      inputTitle.value = tdContents[0].innerText;
      inputAuthor.value = tdContents[1].innerText;
      h3.textContent = `Edit FORM`;
      confirmBtn.textContent = 'Save';
      confirmBtn.id = trData.id;
    }
  }

  async function onDeleteHandler(ev) {
    let entry = ev.currentTarget.parentElement.parentElement;
    let response = await fetch(baseURL + `/${entry.id}`, {
      method: 'DELETE',
    });

    entry.remove();
  }

  // DOM Element Factory Function
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

    content = content.reduce(
      (a, c) => a.concat(Array.isArray(c) ? c : [c]),
      []
    );

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
}

getBookCollection();
