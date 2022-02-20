function validator(obj) {
  let validMehtods = ['GET', 'POST', 'DELETE', 'CONNECT'];
  let validVersion = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];

  let uriRegex = new RegExp(/^[a-z0-9.]+$|^\*$/gm); // matches wanted uri
  let msgRgx = new RegExp(/[<>\\&'"]+/gm); // matches unwanted chars

  if (!validMehtods.includes(obj.method) || obj.method == undefined) {
    throw new Error('Invalid request header: Invalid Method');
  } else if (
    !uriRegex.test(obj.uri) ||
    obj.uri == undefined ||
    obj.uri === ''
  ) {
    throw new Error('Invalid request header: Invalid URI');
  } else if (!validVersion.includes(obj.version) || obj.version == undefined) {
    throw new Error('Invalid request header: Invalid Version');
  } else if (
    (msgRgx.test(obj.message) || obj.message == undefined) &&
    obj.message !== ''
  ) {
    throw new Error('Invalid request header: Invalid Message');
  }

  return obj;
}
console.log(
  validator({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: '',
  }),
);
