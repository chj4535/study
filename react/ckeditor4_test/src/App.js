import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import CKEditor from 'ckeditor4-react';

class App extends Component {
  constructor( props ) {
          super( props );

          this.state = {
              data: '<p>React is really <em>nice</em>!</p>',
              data2:""
          };
          this.onEditorChange = this.onEditorChange.bind( this );
          this.handleClick = this.handleClick.bind(this);
      }

      handleClick(){
        this.setState({
          data2:this.state.data
        });


        fetch('/getdata', {
          method: 'post',
          headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
          },
          body: JSON.stringify({data: this.state.data})
        });
      }

      onEditorChange( evt ) {
          this.setState( {
              data: evt.editor.getData()
          } );
          console.log(this.state.data);
      }

      render() {
          return (
              <div>
                <CKEditor
                  data={this.state.data}
                  onChange={this.onEditorChange} />
                <button onClick={this.handleClick}>copy</button>
                <CKEditor
                  data={this.state.data2}
                />
              </div>
          );
      }
}
export default App;
