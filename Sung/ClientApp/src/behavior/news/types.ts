export interface NewsItem {
  id: string;
  title: string;
  subtitle: string;
  text: string;
  publishingDate: string;
  author: string;
}

export interface NewsCard {
  id: string;
  title: string;
  authorId: string;
  author: string;
  publishingDate: string;
  imageUrl: string;
}