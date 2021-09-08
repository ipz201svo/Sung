import React from 'react';
import { Layout } from './layouts';
import HomePage from './components/objects/home';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import NewsPage from './components/objects/news';
import { NotFoundPage } from './components/objects/system';

function App() {
  return (
    <BrowserRouter>
      <Layout>
        <Switch>
          <Route path="/" exact><HomePage /></Route>
          <Route path="/news/:newsId" exact><NewsPage /></Route>
          <Route path="*"><NotFoundPage /></Route>
        </Switch>
      </Layout>
    </BrowserRouter>
  );
}

export default App;
