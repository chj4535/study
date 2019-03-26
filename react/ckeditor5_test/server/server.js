const express = require('express');
const path = require('path');
const os = require("os");

var fs = require('fs');
var multipart = require('connect-multiparty');
var multipartMiddleware = multipart();

const app = express();
const PORT = process.env.PORT || 4000;

app.use(express.static(path.join(__dirname, '..', 'public/')));

// if you need api routes add them here
app.get("/api/getUsername", function(req, res, next){
res.send({ username: os.userInfo().username });
});

app.get('/show_uploads/:filename', function(req, res) {
  console.log("show_uploads");
  fs.readFile(__dirname + '/../public/uploads/' + req.params.filename,function(err,data){
    if(err) console.log({err:err});
    else{
      res.writeHead(200, { "Context-Type": "image/jpg" });//보낼 헤더를 만듬
                res.write(data);   //본문을 만들고
                res.end();  //클라이언트에게 응답을 전송한다
    }
  });
});

app.post('/uploader', multipartMiddleware, function(req, res) {
    fs.readFile(req.files.upload.path, function (err, data) {
        var newPath = __dirname + '/../public/uploads/' + req.files.upload.name;
        console.log(newPath);
        fs.writeFile(newPath, data, function (err) {
            if (err) console.log({err: err});
            else{
              res.send({
                "uploaded": true,
                "url": 'http://192.168.190.234:4000/show_uploads/' + req.files.upload.name
              })
            }
        });
    });
});

app.listen(PORT, () => {
console.log(`Check out the app at http://localhost:${PORT}`);
});
