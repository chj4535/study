import React from 'react';
import { ThemeProvider,Message,MessageText,AgentBar,Column} from '@livechat/ui-kit'


class Message_ex extends React.Component {
    render(){
        return (
          <ThemeProvider>
          <AgentBar>
          <Column>
          <Message authorName="Jon">
            <MessageText>Hello! I am Jon!</MessageText>
          </Message>
          </Column>
          </AgentBar>
            </ThemeProvider>
        );
    }
}

export default Message_ex;
