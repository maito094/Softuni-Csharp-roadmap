const { expect } = require('chai');
const { before, after, beforeEach, afterEach } = require('mocha');
const { chromium } = require('playwright-chromium');

const host = 'http://localhost:5500/01.Messenger'; // If VS code is opened only inside the root folder of the Application, then the url must be only the localhost:5500, but if opened with several Applications, then must assigne the root path filename to the application!!!


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

  it('loads all messages', async () => {
    await page.goto(host);

    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'GET'),
      page.click('#refresh'),
    ]);

    await page.waitForSelector('#messages');
    const messages = await page.$eval('#messages', (m) => m.value); 

    //console.log(messages);

    expect(messages.length).to.be.greaterThan(0);
    expect(messages).to.contains('Spami: Hello, George nice to see you! :)))');


  });

  it('send a message', async () => {
    await page.goto(host);

    await page.fill('#author', 'Mathew');
    await page.fill('#content', 'Great!');


    const [request] = await Promise.all([
      page.waitForRequest((request) => request.method() == 'POST'),
      page.click('#submit'),
    ]);

    const [req] = await Promise.all([
        page.waitForRequest((request) => request.method() == 'GET'),
        page.click('#refresh'),
      ]);

    await page.waitForSelector('#messages');
    const messages = await page.$eval('#messages', (m) => m.value); 
    //console.log(messages);

    expect(messages.length).to.be.greaterThan(0);
    expect(messages).to.contains('Mathew: Great!');

  });
});
