function lockedProfile() {
  let button = document.querySelectorAll('.profile button');

  for (const btn of button) {
    btn.addEventListener('click', showHideInfo);
  }

  function showHideInfo(e) {
    let parentProfileElement = e.currentTarget.parentElement;

    let radioLockElement = parentProfileElement.querySelector(
      'input[value="lock"]',
    );
    
    let hiddenInfoElement = parentProfileElement.getElementsByTagName('div')[0];

    if (!radioLockElement.checked) {
      if (e.currentTarget.textContent == 'Show more') {
        hiddenInfoElement.style.display = 'block';
        e.currentTarget.textContent = 'Hide it';
      } else {
        hiddenInfoElement.style.display = 'none';
        e.currentTarget.textContent = 'Show more';
      }
    }
  }
}
