import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import { Icon, Input } from 'semantic-ui-react'

class Header extends Component {
  constructor(props) {
      super(props);
      this.state={
        login:this.props.login,
        alarm:this.props.alarm
      };
   }

   Click_Profile=()=>{
     this.setState({ alarm: true });
   }
    render() {
      var alarm_state= 'block';
      var login_state= 'hidden';
      if(this.state.login==false){
        login_state='hidden';
      }
      else{
        login_state='visible';
      }
      if(this.state.alarm==false){
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

export default Header;
