function solve() {
  document.querySelector('#searchBtn').addEventListener('click', onClick);
  
  function onClick() {
     
     let searchText = document.getElementById('searchField').value;
     let tableElement = Array.from(document.querySelectorAll('tbody tr'));

    for (let i = 0; i < tableElement.length; i++) {

      let rowElement = Array.from(tableElement[i].getElementsByTagName('td'));

      for (const col of rowElement) {
        let text = col.textContent;
        if (text.includes(searchText)) {
          tableElement[i].classList.add('select');
          
          break;
        }
        else{
         tableElement[i].classList.remove('select');
        }
       // console.log(text);
      }
    }
    searchText.value='';
    //console.log(tableElement);
  }
}
