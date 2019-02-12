import React, { Component } from 'react';
import { Button, Divider, Form, Grid, Segment } from 'semantic-ui-react'

class Login_form extends Component {
  constructor(props) {
      super(props);
   }
    render() {
      return (
            <Segment >
      <Grid columns={2} relaxed='very' stackable>
        <Grid.Column verticalAlign='middle'>
          <Form size={"big"}>
            <Form.Field width={16}>
            <Form.Input  icon='user' iconPosition='left' label='Username or Email' placeholder='Username or Email' />
            <Form.Input icon='lock' iconPosition='left' label='Password' type='password' />

            <Button content='Login' primary size='big'/>
</Form.Field>
          </Form>
        </Grid.Column>

        <Grid.Column verticalAlign='middle'>
          <Form size={"big"}>
            <Form.Input icon='user' iconPosition='left' label='Username' placeholder='Username' />
            <Form.Input icon='mail' iconPosition='left' label='Email' placeholder='Email' />
            <Form.Input icon='lock' iconPosition='left' label='Password' type='password' />
            <Button content='Sign up' icon='signup' size='big' />
          </Form>
        </Grid.Column>
      </Grid>

      <Divider vertical>Or</Divider>
    </Segment>
        );
    }
}

export default Login_form;
