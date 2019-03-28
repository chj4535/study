import React, { Component } from 'react';
import { Redirect } from 'react-router-dom';

import Header from './header/header';
import Menu from './menu/menu';
import Path_Search from './path_search/path_search';
import Folder_tree from './folder_tree/folder_tree';
import Folder_content from './folder_content/folder_content';

class Main extends Component {
  constructor(props) {
      super(props);
   }
   render() {
     const user=localStorage.getItem("user")
     function redirect() {
       if(user===null){
           return <Redirect to='/login'/>
       }
     }
      return (
        <div >
        {redirect()}
        <div className="header_part">
          <Header/>
          <Menu/>
          <Path_Search/>
        </div>
        <div className="body_part">
          <Folder_tree/>
          <Folder_content/>
        </div>
        </div>
        );
    }
}

export default Main;
