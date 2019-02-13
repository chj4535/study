const express = require('express');
const path = require('path');
const os = require("os");

const app = express();
const PORT = process.env.PORT || 4000;

app.use(express.static(path.join(__dirname, '..', 'public/')));
app.use(express.json());
// if you need api routes add them here
app.get("/api/getUsername", function(req, res, next){
res.send({ username: os.userInfo().username });
});

app.listen(PORT, () => {
console.log(`Check out the app at http://localhost:${PORT}`);
});

app.post("/users/authenticate",function(req,res,next){
  console.log(req.body);

  let data
  if(req.body.lo_id=='111'){
    data = JSON.stringify([]);
    console.log(data);
  } else{
    data = JSON.stringify(req.body);
  }
  res.send(data);
});
