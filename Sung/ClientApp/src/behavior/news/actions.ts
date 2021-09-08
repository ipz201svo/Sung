import { NewsCard, NewsItem } from './types';
export const NEWSCARDS_LOAD = 'NEWS/LOAD' as const;
export const loadNewsCardList = () => ({ type: NEWSCARDS_LOAD });

export const NEWSCARDS_LOADED = 'NEWS/LOADED' as const;
export const loadedNewsCardList = (news: NewsCard[]) => ({ type: NEWSCARDS_LOADED, payload: news });

export type NewsAction = ReturnType<
  | typeof loadNewsCardList
  | typeof loadedNewsCardList
>;