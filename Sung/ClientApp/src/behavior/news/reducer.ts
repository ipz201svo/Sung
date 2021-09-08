import { NEWSCARDS_LOAD, NewsAction, NEWSCARDS_LOADED } from './actions';
import { NewsCard, NewsItem } from './types';

export type NewsState = {
  newsCardList: NewsCard[];
  loading: boolean;
}

const initialState: NewsState = {
  newsCardList: [
    { id: '1', author: 'Vlad', title: 'title', publishingDate: '2021-08-21', authorId: '0000-0000-0000-0000', imageUrl: 'asd' },
  ],
  loading: false,
};

export default function reducer(state = initialState, action: NewsAction): NewsState {
  switch (action.type) {
    case NEWSCARDS_LOAD:
      return {
        ...state,
        loading: true,
      };

    case NEWSCARDS_LOADED:
      return {
        ...state,
        newsCardList: action.payload,
        loading: false,
      } as NewsState;
    default:
      return state;
  }
}