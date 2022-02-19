function search() {
  let searchText = document.getElementById('searchText').value;

  if (searchText === '') {
    return;
  }
  let towns = Array.from(document.querySelectorAll('ul#towns li'));

  let matchesFound = 0;

  for (const el of towns) {
    if (el.textContent.includes(searchText)) {
      el.style.textDecoration = 'underline';
      el.style.fontWeight = 'bold';
      matchesFound++;
    } else {
      el.style.textDecoration = 'none';
      el.style.fontWeight = 'none';
    }
  }

  let result = document.getElementById('result');
  result.textContent = `${matchesFound} matches found`;
}
