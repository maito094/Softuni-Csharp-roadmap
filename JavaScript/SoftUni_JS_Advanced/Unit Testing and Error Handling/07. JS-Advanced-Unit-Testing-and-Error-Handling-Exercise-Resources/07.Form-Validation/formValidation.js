function validate() {
  let userNameInput = document.getElementById('username'); // [3 and 20] only letters and numbers
  let passwordInput = document.getElementById('password'); // [5 and 15] word chars(lettters,numbs and _)
  let confirmPasswordInput = document.getElementById('confirm-password'); // must equal the password
  let emailInput = document.getElementById('email'); // must contain @ and atleast ONE .(dot) after it
  let companyChkBox = document.getElementById('company'); // toggle to show Company info Field
  let companyInfoInput = document.getElementById('companyInfo');
  let companyNumberInput = document.getElementById('companyNumber'); //must be betweeen 1000 and 9999; if CheckBox is Checked
  let divValid = document.getElementById('valid');

  const usrPattern = /^[a-zA-Z0-9]{3,20}$/;
  const usrRegex = new RegExp(usrPattern);

  const pwdPattern = /^[\w]{5,15}$/; ///^\w{5,15}$/;
  const pwdRegex = new RegExp(pwdPattern);

  const emailPattern = /^[^@.]+@[^@]*\.[^@]*$/;///\w+@\w+[.]+\w+/;
  const emailRegex = new RegExp(emailPattern);

  let submitBtn = document.getElementById('submit');
  submitBtn.addEventListener('click', (e) => {
    e.preventDefault();

    let bInvalidInfo = false;

    if (usrRegex.test(userNameInput.value)) {
      userNameInput.setAttribute('style', '');
    } else {
      userNameInput.setAttribute('style', 'border-color: red');
      bInvalidInfo = true;
    }

    if (emailRegex.test(emailInput.value)) {
      emailInput.setAttribute('style', '');
    } else {
      emailInput.setAttribute('style', 'border-color: red');
      bInvalidInfo = true;
    }
    if (
      pwdRegex.test(passwordInput.value) &&
      passwordInput.value === confirmPasswordInput.value
    ) {
      passwordInput.setAttribute('style', '');
      confirmPasswordInput.setAttribute('style', '');
    } else {
      passwordInput.setAttribute('style', 'border-color: red');
      confirmPasswordInput.setAttribute('style', 'border-color: red');
      bInvalidInfo = true;
    }

    if (companyChkBox.checked) {
      if (
        (companyNumberInput.value) >= 1000 &&
        (companyNumberInput.value) <= 9999
      ) {
        companyNumberInput.setAttribute('style', '');//
      } else {
        companyNumberInput.setAttribute('style', 'border-color: red');
        bInvalidInfo = true;
      }
    }

    if (!bInvalidInfo) {
      divValid.style.display = 'block';
    } else {
      divValid.style.display = 'none';
    }
  });
  companyChkBox.addEventListener('change', (e) => {
    if (companyChkBox.checked) {
      companyInfoInput.style.display = 'block';
    } else {
      companyInfoInput.style.display = 'none';
    //   companyNumberInput.value = '';
    //   companyNumberInput.setAttribute('style', '');
    }
  });
}
