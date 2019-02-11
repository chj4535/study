import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { Route } from 'react-router-dom';
import chat_list from './components/chat_list';
import chat_window from './components/chat_window';
import MessageList from './components/MessageList';
import Icon from './components/Icon';
import Message_ex from './components/Message_ex';

class App extends Component {

    state = { username: null };

    componentDidMount() {
        fetch('/api/getUsername')
            .then(res => res.json())
            .then(user => this.setState({ username: user.username }));
    }

  render() {
    const { username } = this.state;
    return (
      <div>
        <Route exact path="/" component={chat_list}/>
        <Route path="/chat_window" component={chat_window}/>
        <Route path="/MessageList" component={MessageList}/>
        <Route path="/Icon" component={Icon}/>
        <Route path="/Message" component={Message_ex}/>
      </div>
    );
  }
}

export default App;
