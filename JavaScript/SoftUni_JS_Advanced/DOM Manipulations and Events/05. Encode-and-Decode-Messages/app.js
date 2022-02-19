function encodeAndDecodeMessages() {
  let [encodeBtn, decodeBtn] = document.getElementsByTagName('button');

  encodeBtn.addEventListener('click', operation);
  decodeBtn.addEventListener('click', operation);

  function operation(e) {
    let textAreaElement =
      e.currentTarget.parentElement.querySelector('textarea');
      let recieveTextArea = decodeBtn.parentElement.querySelector('textarea');
    //console.log(textAreaElement);
    let encodedText
    if (!textAreaElement.disabled) {
       encodedText = Array.from(textAreaElement.value).map((x) =>
        x.charCodeAt(0)+1,
      );
     textAreaElement.value='';
     // console.log(encodedText);
    
    }else{
        encodedText = Array.from(textAreaElement.value).map((x) =>
        x.charCodeAt(0)-1,
      );

    }
    recieveTextArea.value = encodedText.reduce((a,b)=>
    a+String.fromCharCode(b),'') ;

   
  }
}
