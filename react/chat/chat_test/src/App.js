import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import Message from './components/Message/Message';
import Login from './components/Login/Login';
import Header from './components/Header/Header';

class App extends Component {
  constructor(props){
    super(props);
  }
  render() {
    const state = {key:"3",      username:"choi",      text:"안녕"    };
    return (
      <div>
        <Header/>
        <Route exact path="/" render={(props) => ( <Message state={state}/> )} />
        <Route exact path="/login" component={Login} />
      </div>
    );
  }
}

export default App;
