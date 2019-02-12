import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import Login_form from './Login_form';

class Login extends Component {
  constructor(props) {
      super(props);
   }
    render() {
      return (
        <div className="Login_body">
          <div className="Logo_form">
            <div className="Logo_img">
              <img className="round_img" src={Logo} alt="logo"/>
            </div>
            <div className="Logo_name">
              ABC Soft
            </div>
          </div>
          <div className="Login_form">
            <Login_form/>
          </div>
        </div>
        );
    }
}

export default Login;
