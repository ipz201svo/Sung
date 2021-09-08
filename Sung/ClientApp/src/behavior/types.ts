import { Action } from 'redux';
import { StateObservable } from 'redux-observable';
import { Observable } from 'rxjs';
import { AppState } from '.';
import { graph } from '../utils/api';

export type StoreDependencies = {
  api: typeof graph
};

export type Epic<TActions extends Action> = (
  action$: Observable<TActions>,
  state$: StateObservable<AppState>,
  dependencies: StoreDependencies
) => Observable<Action>;