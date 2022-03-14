const { expect } = require('chai');
const { before, after, beforeEach, afterEach } = require('mocha');
const { chromium } = require('playwright-chromium');

const host = 'http://localhost:5500/02.Book-Library'; // If VS code is opened only inside the root folder of the Application, then the url must be only the localhost:5500, but if opened with several Applications, then must assigne the root path filename to the application!!!

// const mockData = {
//   'd953e5fb-a585-4d6b-92d3-ee90697398a0': {
//     author: 'J.K.Rowling',
//     title: "Harry Potter and the Philosopher's Stone",
//   },
//   'd953e5fb-a585-4d6b-92d3-ee90697398a1': {
//     author: 'Svetlin Nakov',
//     title: 'C# Fundamentals',
//   },
// };

// const mockDataDelete = {
//   'd953e5fb-a585-4d6b-92d3-ee90697398a1': {
//     author: 'Svetlin Nakov',
//     title: 'C# Fundamentals',
//   },
// };

describe('Tests', async function () {
  //#region BoilerPlate code for Testing Web Application (End - to - End testing)
  this.timeout(4000); /// Default is 4s for the Tests ,if it is over this time it will fail.

  let browser, page;

  before(async () => {
    // browser = await chromium.launch({ headless: false, slowMo: 1000 });
    browser = await chromium.launch();
  });

  after(async () => {
    await browser.close();
  });

  beforeEach(async () => {
    page = await browser.newPage();
  });

  afterEach(async () => {
    page.close();
  });
  //#endregion

  //   it('works', async () => {
  //     await new Promise((r) => setTimeout(r, 1000));
  //     expect(1).to.equal(1);
  //   });

  it('loads all books', async () => {
    // interception of reuqest
    // await page.route(
    //   '**/02.Book-Library/jsonstore/collections/books', ///02.Book-Library
    //   (route, request) => {
    //     // Add path to Current Application
    //     //console.log('intercepted request');
    //     console.log('Intercepted');
    //     console.log(route.request().postData());
    //     route.fulfill({

    //       body: JSON.stringify(mockData),
    //       status: 200,
    //       headers: {
    //         'Acces-Control-Allow-Origin': '*',
    //         'Content-Type': 'application/json',
    //       },
    //     });
    //   }
    // );

    //navigate to page
    await page.goto(host);
    //await page.screenshot({ path: 'sc.png' });

    // find click Load button
    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'GET'),
      page.click('text=load all books'),
    ]);

    // using a Selector, can be a CSS Selector, but to be from User POV should be like a Visual (text) search. 'text=load all' this pattern is case insensitive and partial match, but 'text="load all"' is case sensitive and exact match !!!
    //console.log('has clicked');

    // check that books are displayed
    await page.waitForSelector('tbody');

    //console.log('has load all');
    const rowData = await page.$$eval('tbody tr', (rows) => rows.map((r) => r)); // this $$eval function sends the desired selector and function on which to execute and returns data.

    // console.log(rowData);
    expect(rowData.length).to.be.greaterThan(0);
    // expect(rowData[0]).to.contains('Harry Potter');
    // expect(rowData[0]).to.contains('Rowling');

    // expect(rowData[1]).to.contains('C# Fundamentals');
    // expect(rowData[1]).to.contains('Nakov');
  });

  it('creates book', async () => {
    // Navigate to page
    await page.goto(host);

    // find form

    // fill input fields
    await page.fill('input[name=title]', 'Title');
    await page.fill('input[name=author]', 'Author');

    // click submit
    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'POST'),
      page.click('text=Submit'),
    ]); // Promise.all is used so that we can intercept both the request and the submit, because otheriwse it is a race condition,
    // and if it is used await separetly for both actions the first one will block the execution of the second, and will not work correctly
    // So we sincronously run both but await for both to be resolved.
    //console.log(request.postData());
    const data = JSON.parse(request.postData());
    expect(data.title).to.equal('Title');
    expect(data.author).to.equal('Author');
  });

  it('Edit book', async () => {
    await page.goto(host);
    await page.click('text=load all books');
    await page.waitForSelector('text=Edit');
    const rowData = await page.$$eval('tbody tr', (rows) =>
      rows.map((r) => r.textContent)
    );
    await page.click('text=Edit');

    // click submit
    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'PUT'),
      page.click('text=Save'),
    ]);
    const data = JSON.parse(request.postData());

    expect(rowData[0]).to.contains(data.title);
    expect(rowData[0]).to.contains(data.author);
  });

  it('Delete book Yes', async () => {
    // Navigate to page
    await page.goto(host);
    // load all books
    await page.click('text=load all books');
    // wait for books to load
    await page.waitForSelector('text=Delete');

    const oldData = await page.$$eval('tbody tr', (rows) => rows.map((r) => r));
    const oldLength = oldData.length;

    // find delete button and del request
    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'DELETE'),
      page.click('text=Delete'),
      page.on('dialog', async (dialog) => {
        console.log(dialog.message());
        await dialog.accept('ok');
      }),
    ]);

    // load all books
    //wait for books to load
    const [req] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'GET'),
      page.click('text=load all books'),
    ]);

    const data = await page.$$eval('tbody tr', (rows) => rows.map((r) => r));
    // const data = await page.$$eval('tbody tr', (rows) => rows.map((r) => r.textContent));

    expect(data.length).to.be.lessThan(oldLength);
  });

  it('Delete book No', async () => {
    // Navigate to page
    await page.goto(host);
    // load all books
    await page.click('text=load all books');
    // wait for books to load
    await page.waitForSelector('text=Delete');

    const oldData = await page.$$eval('tbody tr', (rows) => rows.map((r) => r));
    const oldLength = oldData.length;
    // find delete button and del request
    const [request] = await Promise.all([
      //page.waitForRequest((request) => request.method() == 'DELETE'), // For Test
      page.click('text=Delete'),
      page.on('dialog', async (dialog) => {
        console.log(dialog.message());
        await dialog.dismiss('cancel'); // await dialog.accept('ok'); // For test
      }),
    ]);

    // load all books

    // wait for books to load
    const [response] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'GET'),
      page.click('text=load all books'),
    ]);

    const data = await page.$$eval('tbody tr', (rows) => rows.map((r) => r));
    expect(data.length).to.be.equal(oldLength);
  });
});
