import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import { Icon, Input } from 'semantic-ui-react'
import { connect } from 'react-redux';
class Header extends Component {


   // Click_Profile=()=>{
   //   this.setState({ alarm: !this.state.alarm });
   // }

    render() {
      const {store_login, store_alarm} = this.props;
      var alarm_state= '';
      var login_state= '';
      if(store_login==false){
        login_state='hidden';
      }
      else{
        login_state='visible';
      }
      if(store_alarm==false){
        alarm_state='none';
      }
      else{
        alarm_state='block';
      }
      return (
        <div className="Header_body">
          <div className="Header_Logo">
            <img className="round_img"src={Logo} alt="logo" />
          </div>
          <div className="Header_Searchbar">
             <Input style={{width:"100%"}} size="huge" icon={<Icon name='search' inverted circular link />} placeholder='Search...' />
          </div>
          <div className="Header_Profile_form">
            <div className="Header_Profile" style={{visibility:login_state}}  onClick={this.Click_Profile}>
            <img className="round_img" src={Logo} alt="logo"/>
            <Icon size='large' name='caret down'/>
            </div>
          </div>

          <div className="Header_Alarm">
            <Icon.Group size='big' style={{visibility:login_state}}>
            <Icon color='black'  name='alarm' circular inverted/>
            <Icon style={{display:alarm_state}} color='red' corner name='exclamation' />
            </Icon.Group>

          </div>
        </div>

        );
    }
}


const get_Login_state = (state) => {
  return {
    todos: state.todos,
    store_login: state.store_login,
    store_alarm:state.store_alarm
  }
}

export default connect(get_Login_state,undefined)(Header);
