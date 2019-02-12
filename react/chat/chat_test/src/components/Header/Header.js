import React, { Component } from 'react';
import Logo from '../Logo/atomic.png';
import { Icon, Input } from 'semantic-ui-react'

class Header extends Component {
  constructor(props) {
      super(props);
   }
    render() {
      var alarm_exist= 'block';
      var alarm_none= 'none';
      return (
        <div className="Header_body">
          <div className="Header_Logo">
            <img className="round_img"src={Logo} alt="logo" />
          </div>
          <div className="Header_Searchbar">
             <Input style={{width:"100%"}} size="huge" icon={<Icon name='search' inverted circular link />} placeholder='Search...' />
          </div>

          <div className="Header_Profile_form">
            <div className="Header_Profile">
            <img className="round_img" src={Logo} alt="logo"/>
            <Icon size='large' name='caret down'/>
            </div>
          </div>

          <div className="Header_Alarm">
            <Icon.Group size='big'>
            <Icon color='black'  name='alarm' circular inverted/>
            <Icon style={{display:alarm_exist}} color='red' corner name='exclamation' />
            </Icon.Group>
          </div>



        </div>
        );
    }
}

export default Header;
