import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import Main from './components/Main/Main'
import Login from './components/Login/Login';
import Header from './components/Header/Header';

class App extends Component {
  constructor(props){
    super(props);
  }
  render() {
    return (
      <div>
        <Header/>
        <Route exact path="/" component={Main} />
        <Route exact path="/login" component={Login} />
      </div>
    );
  }
}

export default App;
