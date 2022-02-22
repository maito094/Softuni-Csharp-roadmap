function solution() {
  class Post {
    constructor(title, content) {
      this.title = title;
      this.content = content;
    }

    toString() {
      return `Post: ${this.title}
Content: ${this.content}`;
    }
  }

  class SocialMediaPost extends Post {
    constructor(title, content, likes, dislikes) {
      super(title, content);
      this._likes = Number(likes);
      this._dislikes = Number(dislikes);
      this._comments = [];
    }
    addComment(comment) {
      this._comments.push(' * ' + comment);
    }
    get likes() {
      return this._likes;
    }
    get dislikes() {
      return this._dislikes;
    }
    get comments() {
      return this._comments;
    }

    toString() {
      let result = [
        `Post: ${this.title}
Content: ${this.content}
Rating: ${this.likes - this.dislikes}`,
      ];
      if (this.comments.length > 0) {
        result.push(['Comments:']);
        this.comments.forEach((e) => {
          result.push(e);
        });
        result = result.join('\n');
      }

      return result.toString();
    }
  }

  class BlogPost extends Post {
    constructor(title, content, views) {
      super(title, content);

      this._views = Number(views);
    }

    get views() {
      return this._views;
    }
    view() {
      this._views++;
      return this;
    }

    toString() {
      return `Post: ${this.title}
Content: ${this.content}
Views: ${this.views}`;
    }
  }

  return { Post, SocialMediaPost, BlogPost };
}

const classes = solution();
let post = new classes.Post('Post', 'Content');

console.log(post.toString());

// Post: Post
// Content: Content

let scm = new classes.SocialMediaPost('TestTitle', 'TestContent', 25, 30);

scm.addComment('Good post');
scm.addComment('Very good post');
scm.addComment('Wow!');

console.log(scm.toString());

let blog = new classes.BlogPost('Blog', 'BlogContent', 20);

blog.view().view().view().view().view();

console.log(blog.toString());

// Post: TestTitle
// Content: TestContent
// Rating: -5
// Comments:
//  * Good post
//  * Very good post
//  * Wow!
