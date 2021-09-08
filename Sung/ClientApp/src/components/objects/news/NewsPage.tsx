import React from 'react';
import { useParams } from 'react-router-dom';
import { Main, Sidebar, Top } from './sections';

function NewsPage() {
  const { newsId } = useParams<{ newsId: string }>();
  return (
    <>
      <Top />
      NEWS {newsId}
      <Sidebar />
      <Main />
    </>
  );
}

export default NewsPage;