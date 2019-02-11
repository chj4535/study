import React from 'react';
import { ThemeProvider,Row,IconButton,SendIcon,RateBadIcon,RateGoodIcon,EmojiIcon,CloseIcon,ChatIcon,MenuVerticalIcon,AddIcon} from '@livechat/ui-kit'


class Icon extends React.Component {
    render(){
        return (
          <ThemeProvider>
          <Row>
            <IconButton>
              <SendIcon color="#4788ef" />
            </IconButton>
            <IconButton>
              <RateGoodIcon color="#14e5d7" />
            </IconButton>
            <IconButton>
              <RateBadIcon color="#cc0237" />
            </IconButton>
            <IconButton>
              <EmojiIcon color="#ff9811" />
            </IconButton>
            <IconButton>
              <AddIcon color="#59a19e" />
            </IconButton>
            <IconButton>
              <CloseIcon color="#636363" />
            </IconButton>
            <IconButton>
              <ChatIcon color="#0854a5" />
            </IconButton>
            <IconButton>
              <MenuVerticalIcon color="#001c3a" />
            </IconButton>
          </Row>
            </ThemeProvider>
        );
    }
}

export default Icon;
