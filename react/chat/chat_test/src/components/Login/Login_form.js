import React, { Component } from 'react';
import { Button, Divider, Form, Grid, Segment } from 'semantic-ui-react';
import { connect } from 'react-redux';
import { login_try } from '../../action/login_register';

class Login_form extends Component {
  constructor(props) {
      super(props);
      this.state = {
        login_id: '',
        login_password: '',
        register_Username: '',
        register_password: '',
        register_Email: ''
      };
      this.handleChange = this.handleChange.bind(this);
   }

   clear

   handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    render() {
      const {onClick} = this.props;
      return (
            <Segment >
      <Grid columns={2} relaxed='very' stackable>
        <Grid.Column verticalAlign='middle'>
          <Form size={"big"}>
            <Form.Field width={16}>
            <Form.Input  icon='user' iconPosition='left' label='Username or Email' placeholder='Username or Email' name='login_id' value={this.state.login_id} onChange={this.handleChange}/>
            <Form.Input icon='lock' iconPosition='left' label='Password' type='password' name='login_password' value={this.state.login_password} onChange={this.handleChange}/>

            <Button content='Login' primary size='big' onClick={()=>{
                let state={
                  lo_id:this.state.login_id,
                  lo_pw:this.state.login_password
                }
                onClick('login',state);
        }}/>
</Form.Field>
          </Form>
        </Grid.Column>

        <Grid.Column verticalAlign='middle'>
          <Form size={"big"}>
            <Form.Input icon='user' iconPosition='left' label='Username' placeholder='Username'name='register_Username' value={this.state.register_Username} onChange={this.handleChange}/>
            <Form.Input icon='mail' iconPosition='left' label='Email' placeholder='Email' name='register_Email' value={this.state.register_Email} onChange={this.handleChange}/>
            <Form.Input icon='lock' iconPosition='left' label='Password' type='password' name='register_password' value={this.state.register_password} onChange={this.handleChange}/>
            <Button content='Sign up' icon='signup' size='big' />
          </Form>
        </Grid.Column>
      </Grid>

      <Divider vertical>Or</Divider>
    </Segment>
        );
    }
}

const login_register = (dispatch) => {
  return {
    onClick(type,info){
      if(type=='login'){
        dispatch(login_try(info))
      }
      else{

      }
    }
  }
}


export default connect(undefined, login_register)(Login_form);
