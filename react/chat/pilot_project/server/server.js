const express = require('express');
const path = require('path');
const os = require("os");
var exec = require('child_process').exec;
var fs = require('fs');
var d = require('diskinfo');

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

app.get("/distlist",function(req,res){
  var oProcess = exec(
    'wmic logicaldisk get Caption,FreeSpace,Size,VolumeSerialNumber,Description,volumename /format:list > test1.txt'
  ,function (err, stdout, stderr) {
    console.log(stdout);
    fs.readFile("test1",function(err,data){
      count=0;
      file=""
      //console.log(data);
      while(count<data.length){
        text=""
        text+=" "+data[count+1].toString(16);
        text+=data[count].toString(16);
        file+=" "+data[count+1].toString(16);
        file+=data[count].toString(16);
        console.log(text);
        count+=2;

      }
      console.log(file);
      var set=['ff','fe','5c','b8','ec','ce','20','0','e0','ac','15','c8','20','0','14','b5','a4','c2','6c','d0'];

      file="";
      count=0;
      while(count<set.length){
        console.log(parseInt(set[count], 16));
        data[count]=set[count];
        count++;
      }
      fs.writeFile('decod.txt', data, function(err) {
        console.log('비동기적 파일 쓰기 완료');
      });

      res.send(data);
    });
      //console.log(data)
  });
});
