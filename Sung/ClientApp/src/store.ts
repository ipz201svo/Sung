import { applyMiddleware, combineReducers, createStore } from 'redux';
import { createEpicMiddleware } from 'redux-observable';
import reducers from './behavior/rootReducer';
import { composeWithDevTools } from 'redux-devtools-extension';
import rootEpic from './behavior/rootEpic';
import { AppState } from './behavior';
import { StoreDependencies } from './behavior/types';

export interface configureStoreParams {
  dependencies: StoreDependencies;
  initialState?: AppState;
}

export default function configureStore(dependencies: StoreDependencies, initialState?: AppState) {
  const epicMiddleware = createEpicMiddleware({ dependencies });
  const middleware = [epicMiddleware];
  const middlewareEnhancer = applyMiddleware(...middleware);

  const enhancers = [middlewareEnhancer];
  const composedEnhancers = composeWithDevTools(...enhancers);

  const rootReducer = combineReducers({ ...reducers });
  const store = createStore(
    rootReducer,
    initialState,
    composedEnhancers,
  );

  epicMiddleware.run(rootEpic);

  return store;
}