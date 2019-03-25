import React, { Component } from 'react';
import ClassicEditor from '@ckeditor/ckeditor5-build-classic';

var edit1_data=0;
var edit2_data=0;

class edit extends Component {
  constructor(props) {
      super(props);
   }

   componentDidMount() {
   ClassicEditor
   	.create( document.querySelector( '#editor1' ),{
      ckfinder: {
        uploadUrl: '127.0.0.1/' // 내가 지정한 업로드 url (post로 요청감)
    }
    })
   	.then( editor => {
      edit1_data=editor;
   		window.editor = editor;
   	} )
   	.catch( err => {
   		console.error( err.stack );
   	} );
    ClassicEditor
    	.create( document.querySelector( '#editor2' ) )
    	.then( editor => {
       edit2_data=editor;
    		window.editor = editor;
    	} )
    	.catch( err => {
    		console.error( err.stack );
    	} );
   }

   myFunction(){
     if ( edit1_data.getData() == '' ){
       console.log( 'There is no data available.' );
     }
     else{
      edit2_data.setData(edit1_data.getData());
     }

    }

    render() {

      return (
        <div>
          <div id="editor1">
            <p>This is the editor content.</p>
          </div>
          <div>
            <button onClick={this.myFunction}>df</button>
          </div>
          <div id="editor2">
            <p>This is the editor content.</p>
          </div>
        </div>
        );
    }
}

export default edit;
