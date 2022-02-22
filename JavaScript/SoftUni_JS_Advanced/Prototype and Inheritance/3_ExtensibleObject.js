// (function solve() {
function extensibleObject() {

  const extend= function (template){
    
    for (let prop in template) {
      if (typeof template[prop] == 'function') {
        extensibleObject.prototype[prop] = template[prop];
      } else {
        this[prop] = template[prop];
      }
    }
    
  };
  Object.setPrototypeOf(extensibleObject,extend)
  return extensibleObject;
}

// extensibleObject.prototype.extend = function (template) {
//     for (let prop in template) {
//       if (typeof template[prop] == 'function') {
//         extensibleObject.prototype[prop] = template[prop];
//       } else {
//         this[prop] = template[prop];
//       }
//     }
//   };

// extensibleObject.prototype.extend = function extend(template) {
//   for (let prop in template) {
//     if (typeof template[prop] == 'function') {
//       extensibleObject.prototype[prop] = template[prop];
//     } else {
//       this[prop] = template[prop];
//     }
//   }
//   return extensibleObject.extend();
//   //return Object.getPrototypeOf(this);
// };

//return this;

//   return extensibleObject;
// })();

const myObj = extensibleObject();

console.log(myObj);

const template = {
  extensionMethod: function () {},
  extensionProperty: 'someString',
};

console.log(myObj.extend(template));
