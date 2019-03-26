import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

import CKEditor from '@ckeditor/ckeditor5-react';
import ClassicEditor from '@ckeditor/ckeditor5-build-classic';

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


    // fetch('/getdata', {
    //   method: 'post',
    //   headers: {
    //     'Accept': 'application/json',
    //     'Content-Type': 'application/json'
    //   },
    //   body: JSON.stringify({data: this.state.data})
    // });
  }

  onEditorChange( editor ) {
      this.setState( {
          data: editor.getData()
      } );
      console.log(this.state.data);
  }

  render() {
    return (
      <div id="editor">
        <CKEditor
          editor={ ClassicEditor }
          data={this.state.data}
          config={{
            ckfinder:{uploadUrl: "/uploader"},
            mediaEmbed:{previewsInData:true}
          }}
          onInit={ editor => {
            // You can store the "editor" and use when it is needed.
            console.log( 'Editor is ready to use!', editor );
          } }
          onChange={ ( event, editor ) => {
            this.onEditorChange(editor)
          } }
          onBlur={ editor => {
            console.log( 'Blur.', editor );
          } }
          onFocus={ editor => {
            console.log( 'Focus.', editor );
          } }
        />
      <button onClick={this.handleClick}>copy</button>
          <CKEditor
            editor={ ClassicEditor }
            data={this.state.data2}
          />
      </div>
    );
  }
}

export default App;
