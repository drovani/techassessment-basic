"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var BlogPost = /** @class */ (function () {
    function BlogPost(title, postedBy, bodyText) {
        this.title = title;
        this.postedBy = postedBy;
        this.bodyText = bodyText;
        /// generate a version 4 UUID
        this.id = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
            return v.toString(16);
        });
        this.postedOn = new Date();
    }
    return BlogPost;
}());
exports.BlogPost = BlogPost;
//# sourceMappingURL=blogpost.js.map