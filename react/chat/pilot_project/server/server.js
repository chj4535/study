const express = require('express');
const path = require('path');
const os = require("os");
var exec = require('child_process').exec;
var fs = require('fs');
const drivelist = require('drivelist');
var async = require("async");

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

app.get("/getfiles",function(req,res){//보낸 경로의 파일 및 폴더 읽기
  files_info=[];
  const req_path = req.body.path;
  console.log(req_path);
  fs.readdir(req_path, (err, files) => {
    //console.log("filse : ",files);
    if(err) res.send(err);
    else if(files.length==0){
      console.log("empty");
      res.send("empty");
    }
    else{
      async.forEachOf(files,function(messageId, callback) {
        var file_info=[];
        var file_path=req_path+"\\"+messageId;
        file_info.push(file_path);
        console.log(file_path);
        var stats = fs.statSync(file_path,callback);
        file_info.push(stats);
        console.log(stats.isDirectory());
        file_info.push(stats.isDirectory());
        files_info.push({file_info});
      },function(err) {
        if (err) {
          console.log("err: ",err);
          return next(err);
        }
        //Tell the user about the great success
        console.log("hello");
      });
    }
    console.log("end");
    res.send(files_info);
  });
});

app.get("/disklist2",async (req,res)=>{//디스크 정보를 받아옵니다.
  const drives = await drivelist.list();
  res.send(drives);
});

app.get("/disklist",function(req,res){//디스크 정보를 받아옵니다.
  var oProcess = exec(
    'wmic logicaldisk get Caption,FreeSpace,Size,VolumeSerialNumber,Description,volumename /format:list > diskinfo'
  ,function (err, stdout, stderr) {
    if (err) return callback(err, null);
    var data = fs.readFileSync("diskinfo", "utf16le")
    var aDrives = [];
    var bNew = false;
    var aLines = data.split('\r\n');
    var sCaption = '', sDescription = '', sFreeSpace = '', sSize = '', sVolume = '', sVolumename='';
    for(var i = 0; i < aLines.length; i++) {
      if (aLines[i] != '') {
        console.log("alines : ",aLines[i]);
        var aTokens = aLines[i].split('=');
        switch  (aTokens[0]) {
          case 'Caption':
            sCaption = aTokens[1];
            bNew = true;
            break;
          case 'Description':
            sDescription = aTokens[1];
            break;
          case 'FreeSpace':
            sFreeSpace = aTokens[1];
            break;
          case 'Size':
            sSize = aTokens[1];
            break;
          case 'VolumeSerialNumber':
            sVolume = aTokens[1];
            break;
          case 'VolumeName':
            sVolumename = aTokens[1];
            break;
        }
      } else {
        if (bNew) {
          sSize = parseFloat(sSize);
          if (isNaN(sSize)) {
            sSize = 0;
          }
          sFreeSpace = parseFloat(sFreeSpace);
          if (isNaN(sFreeSpace)) {
            sFreeSpace = 0;
          }

          var sUsed = (sSize - sFreeSpace);
          var sPercent = '0%';
          if (sSize != '' && parseFloat(sSize) > 0) {
            sPercent = Math.round((parseFloat(sUsed) / parseFloat(sSize)) * 100) + '%';
          }
          aDrives[aDrives.length] = {
            filesystem:	sDescription,
            blocks:		sSize,
            used:		sUsed,
            available:	sFreeSpace,
            capacity:	sPercent,
            mounted:	sCaption,
            name:sVolumename,
          };
          bNew = false;
          sCaption = ''; sDescription = ''; sFreeSpace = ''; sSize = ''; sVolume = ''; sVolumename='';
        }
      }
    }
    //console.log(aDrives);
    res.send(aDrives);
  });
});
