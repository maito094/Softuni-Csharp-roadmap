function getArticleGenerator(articles) {
  let theseArticles = articles;

  return () => {
    if (theseArticles.length > 0) {
      let container = document.getElementById('content');
      let article = document.createElement('article');
      let currentText = theseArticles.shift();
      article.innerText = currentText;

      container.appendChild(article);
    }
  };
}
