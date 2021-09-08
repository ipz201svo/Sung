import { combineEpics } from 'redux-observable';
import appEpic from './app/epic';
import newsEpic from './news/epic';

export default combineEpics(
  newsEpic,
);