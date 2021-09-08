import React from 'react';
import CardGroup from 'react-bootstrap/CardGroup';
import { NewsCard } from '.';
import { NewsItem } from '../../behavior/news/types';

interface Props {
  data: {
    id: string;
    title: string;
    authorId: string;
    author: string;
    publishingDate: string;
    imageUrl: string;
  }[]
}

function NewsCardList({ data }: Props) {
  return (
    <>
      <CardGroup>
        {data.map(news => {
          return (
            <NewsCard
              news={{
                id: news.id,
                title: news.title,
                author: news.author,
                authorId: news.authorId,
                publishingDate: news.publishingDate,
                imageUrl: news.imageUrl,
              }}
              orientation={'vertical'}
              key={news.id}
            />
          );
        })}
      </CardGroup>
    </>
  );
}

export default NewsCardList;