
// action type
const Login_fail = 'Login_fail'
const Login_Success = 'Login_Success'

// action creators
function login_state(data){
  if(data!=''){
    return {type:Login_Success,data};
  }
  else{
    return {type:Login_fail,data};
  }
}

function login_try(info){
  return (dispatch)=>{
    return fetch('/users/authenticate',{
      method: "POST",
      headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    },
      body: JSON.stringify(info)
    }).then(res => res.json())
      .then(res => {
      console.log(res);
       dispatch(login_state(res));
       localStorage.setItem('user',JSON.stringify(info));
       localStorage.setItem('login_state',true);
    });
  }
}

export  {
  Login_fail,
  Login_Success,
	login_state,
  login_try
}
