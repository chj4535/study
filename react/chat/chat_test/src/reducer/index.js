import todos from "./todos";
import store_login from "./store_login";
import store_alarm from "./store_alarm";
import { combineReducers } from "redux";

export default combineReducers({
  todos,
  store_login,
  store_alarm
});
