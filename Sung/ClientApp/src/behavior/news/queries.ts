export const newsQuery = `{
  newsList {
    id
    title
    subtitle
    text
    authorId
    publishingDate
    imageUrl
  }
}`;

export const newsCardListQuery = `{
  newsCardList {
    id
    title
    authorId
    author
    publishingDate
    imageUrl
  }
}`;