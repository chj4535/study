import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Redirect } from 'react-router-dom';
class Main extends Component {
  constructor(props) {
      super(props);
   }
   render() {
     const {store_login} = this.props;
     function redirect() {
       if(!store_login){
           return <Redirect to='/login'/>
       }
     }
      return (
        <div >
        {redirect()}
        메인창
        </div>
        );
    }
}
const get_Login_state = (state) => {
  return {
    store_login: state.store_login
  }
}

export default connect(get_Login_state,undefined)(Main);
