import Action from '../action/index';
const {Login_fail, Login_Success} = Action.login_register;

const store_login = (state = [], action) => {
  switch (action.type) {
    case Login_fail:
      return false;
    case Login_Success:
      return true;
    default:
      return false;
  }
}

export default store_login;
