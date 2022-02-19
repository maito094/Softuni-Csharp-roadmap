 function toggle() {
    let btnElement = document.querySelector('span.button');
    let extraInfo = document.getElementById('extra');

    if (btnElement.textContent=='More') {
        btnElement.textContent='Less';
        extraInfo.style.display='block';
    }else{
        btnElement.textContent='More';
        extraInfo.style.display='none';
    }
}