import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import Login_form from './Login_form';
import { connect } from 'react-redux';
import { Redirect } from 'react-router-dom';
class Login extends Component {
  constructor(props) {
      super(props);
     this.onClick = this.onClick.bind(this);
   }
   componentDidMount() {
    this.checkUser();
  }
  componentWillUpdate(){
    //localStorage에 등록까지 시간이 걸림! 그 시간만큼 대기
    setTimeout(function() { //Start the timer
      this.setState({render: true}) //After 1 second, set render to true
  }.bind(this), 1000)
    this.checkUser();
  }
  onClick(){
    this.checkUser();
  }
  checkUser = () => {
    const {history} = this.props;
    if (localStorage.getItem("user")!=null) {
      history.push("/");
    }
  }
    render() {
      return (
        <div>
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
              <Login_form onClick={this.onClick}/>
            </div>
          </div>
        </div>
        );
      }
}

export default Login;
