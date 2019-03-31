import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

import smartform from 'smart_editor2/dist/SmartEditor'

class App extends Component {
  render() {
    return (
      <div>
        <smartform></smartform>
      </div>
    );
  }
}

export default App;
