import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import { BrowserRouter } from 'react-router-dom';

import configureStore from './store/index';
import { Provider } from 'react-redux';
import reducer from './reducer/index';

const store = configureStore(reducer,{
});

const render = () => {
  ReactDOM.render(
  	<Provider store={store}>
      <BrowserRouter>
	       <App/>
      </BrowserRouter>
    </Provider>,
    document.getElementById('root')
  )
};

store.subscribe(render);
render();
