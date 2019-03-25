import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

import { Route } from 'react-router-dom';
import main from './components/Main/main';
import edit from './components/Edit/edit';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div>
          <Route exact path="/main" component={main}/>
          <Route exact path="/edit" component={edit}/>
        </div>
      </div>
    );
  }
}

export default App;
