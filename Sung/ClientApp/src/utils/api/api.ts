import { Observable } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { map, switchMap } from 'rxjs/operators';

export {
  graph,
};

type GraphApiOptions = {
  authToken?: string | null;
}

function graph(
  query: string,
  options: GraphApiOptions,
  variables?: unknown,
): Observable<any> {
  //const authToken = 'authToken' in options ? options.authToken : tokenStorage.getValue();

  return fromFetch('/api', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      'Accept': 'application/json',
      // 'Authorization': `Bearer ${authToken}`,
    },
    body: JSON.stringify({ query, variables }),
  }).pipe(
    switchMap(res => res.json()),
    map(res => res.data),
  );
}