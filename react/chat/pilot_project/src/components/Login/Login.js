import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import Login_form from './Login_form';
import { connect } from 'react-redux';
import { Redirect } from 'react-router-dom';
class Login extends Component {
  constructor(props) {
      super(props);
   }
    render() {
      const {store_login} = this.props;
      function redirect() {
        if(store_login){
            return <Redirect to='/'/>
        }
      }
      return (
        <div>
          {redirect()}
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
        </div>
        );
      }
}
const get_Login_state = (state) => {
  return {
    store_login: state.store_login
  }
}

export default connect(get_Login_state,undefined)(Login);
