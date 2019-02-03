export class BlogPost {
  id: string;
  postedOn: Date;

  constructor(
    public title?: string,
    public postedBy?: string,
    public bodyText?: string
  ) {
    /// generate a version 4 UUID
    this.id = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
    this.postedOn = new Date();
  }
}
