function attachEventsListeners() {
  let btnsElements = document.querySelectorAll('input[type="button"]');
  let inputElements = Array.from(
    document.querySelectorAll('input[type="text"]'),
  );

  let timeRatio = [];

//   console.log(btnsElements);
//   console.log(inputElements);

  for (const btn of btnsElements) {
    btn.addEventListener('click', convertHandler);
  }

  function convertHandler(event) {
    let btn = event.currentTarget;

    let inputElement = inputElements.find((x) => btn.id.includes(x.id));

    if (inputElement.id.includes('day')) {
      timeRatio = [1, 24, 1440, 86400];
    } else if (inputElement.id.includes('hours')) {
      timeRatio = [1 / 24, 1, 60, 3600];
    } else if (inputElement.id.includes('minutes')) {
      timeRatio = [1 / 1440, 1 / 60, 1, 60];
    } else if (inputElement.id.includes('seconds')) {
      timeRatio = [1 / 86400, 1 / 3600, 1 / 60, 1];
    }

    let inputValue = Number(inputElement.value);
    if (!inputValue) {
      return;
    }
    for (let i = 0; i < inputElements.length; i++) {
      inputElements[i].value = null; 
      inputElements[i].value += timeRatio[i] * inputValue;
    
    }
    // let result = inputElements.map(convertTime, inputElement);

    // function convertTime(x) {
    //   let inputValue = Number(this.value);

    //   let convertedTime = 0;
    //   if (inputValue == x.value) {
    //     return x.value;
    //   }
    //   if (x.id.includes('seconds')) {
    //     let multiiple = 60;
    //   }
    //   return convertedTime; //this;
    // }

    //console.log(result);

    console.log(inputValue);
  }
}
