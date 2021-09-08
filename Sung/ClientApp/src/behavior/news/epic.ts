import { Epic, ofType } from 'redux-observable';
import { mergeMap, map } from 'rxjs/operators';
import { loadedNewsCardList } from '.';
// import { Epic } from '../types';
import { NewsAction, NEWSCARDS_LOAD } from './actions';
import { newsCardListQuery } from './queries';
import { NewsCard, NewsItem } from './types';

type newsType = {
  newsCardList: NewsCard[];
}

const epic: Epic = (action$, state$, { api }) => action$.pipe(
  ofType(NEWSCARDS_LOAD),
  mergeMap(action => api(newsCardListQuery, {}).pipe(
    map((news: newsType) => loadedNewsCardList(news.newsCardList)),
  )));

export default epic;