function attachEventsListeners() {
  let btnsElements = document.querySelectorAll('input[type="button"]');
  let inputElements = Array.from(
    document.querySelectorAll('input[type="text"]'),
  );

  let timeRatio = {
    days: 1,
    hours: 24,
    minutes: 1440,
    seconds: 86400,
  };

  for (const btn of btnsElements) {
    btn.addEventListener('click', convertHandler);
  }

  function convertHandler(event) {
    let btn = event.currentTarget;
    let inputElement = inputElements.find((x) => btn.id.includes(x.id));

    let time = conversionUnit(Number(inputElement.value), inputElement.id);
    
    for (const keyUnit in time) {
      inputElements.find(k=>k.id===keyUnit).value=time[keyUnit];
    }
  }

  function conversionUnit(value, unit) {
    let converted = value / timeRatio[unit];

    return {
      days: converted,
      hours: converted * timeRatio.hours,
      minutes: converted * timeRatio.minutes,
      seconds: converted * timeRatio.seconds,
    };
  }
}
