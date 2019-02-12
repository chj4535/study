import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import Message from './components/Message/Message';
import Login from './components/Login/Login';
import Header from './components/Header/Header';

class App extends Component {
  constructor(props){
    super(props);
    this.state = {
      login : true,
      alarm : false
    };
  }
  render() {
    const state = {key:"3",      username:"choi",      text:"안녕"    };
    return (
      <div>
        <Header login={this.state.login} alarm={this.state.alarm}/>
        <Route exact path="/" render={(props) => ( <Message state={state}/> )} />
        <Route exact path="/login" render={(props) => ( <Login login={this.state.login}/> )} />

      </div>
    );
  }
}

export default App;
