import React, { Component } from 'react';


class Message extends Component {
  constructor(props) {
      super(props);
   }
    render() {
      return (
        <div className="message">
          <div className="message-username">{this.props.state.username}</div>
          <div className="message-text">{this.props.state.text}</div>
        </div>
        );
    }
}

export default Message;
