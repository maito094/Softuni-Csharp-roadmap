function notify(message) {
  let DivEl = document.getElementById('notification');
  DivEl.textContent = message;

  DivEl.style.display = 'block';

  DivEl.addEventListener('click', (e) => {
    e.currentTarget.style.display = 'none';
  });
}
