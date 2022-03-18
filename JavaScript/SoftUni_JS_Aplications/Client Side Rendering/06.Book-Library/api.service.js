const baseURL = 'http://localhost:3030/jsonstore/collections/books';


async function getBooks() {
    let res = await fetch(baseURL);
    let data = Object.entries(await res.json());
    console.log(data);
    return data;
  }

async function getBookById(_id) {
    let res = await fetch(baseURL+`/${_id}`);
    let data = await res.json();
    data['_id']=_id;
    console.log(data);
    return data;
  }
  
  async function postBooks(dataEntry) {
    let res = await fetch(baseURL, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(dataEntry),
    });
  }
  
  async function updateBook(dataEntry,_id) {
    let res = await fetch(baseURL+`/${_id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(dataEntry),
    });
  }
  
  async function deleteBook(_id) {
    let res = await fetch(baseURL+`/${_id}`, {
      method: 'DELETE',
      headers: {
        'Content-Type': 'application/json',
      },
    });

  }

  export {getBooks,getBookById,postBooks,deleteBook,updateBook };