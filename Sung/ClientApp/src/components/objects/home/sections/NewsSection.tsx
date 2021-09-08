import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { AppState } from '../../../../behavior';
import { loadNewsCardList } from '../../../../behavior/news';
import { BigNewsCard, NewsCardList } from '../../../newsCard';

function NewsSection() {
  const state = useSelector((state: AppState) => state.news);
  const dispatch = useDispatch();
  const bigNews = state.newsCardList[0];

  useEffect(() => {
    dispatch(loadNewsCardList());
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return (
    <>
      <BigNewsCard title={bigNews.title} author={bigNews.author} publishingDate={bigNews.publishingDate} authorId={bigNews.authorId} id={bigNews.id} imageUrl={bigNews.imageUrl} />
      <NewsCardList data={state.newsCardList} />
    </>
  );
}

export default NewsSection;