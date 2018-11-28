const express = require('express');
const fs = require('fs');
const bodyparser = require('body-parser');
const mysql = require('mysql');
const app = express();

/*소켓 연결 부분 */
const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
var io = require('socket.io').listen(6000);
var channel;
const dbName = 'db';

io.on('connection', function (socket) {
    console.log('connect');
    var instanceId = socket.id;

    socket.on('joinRoom',function (data) {
        console.log(data);
        socket.join(data.channel);
        channel = data.channel;
        console.log(channel);
        MongoClient.connect('mongodb://localhost:27017/', function (error, client) {
            console.log(channel);
            if (error) console.log(error);
            else {
                // const db = client.db(dbName);
                // db.collection('log').find({channel:channel}).sort({data:1}).toArray(function(err,doc){
                //     if (err) console.log(err);
                //     doc.forEach(function(item){
                //         console.log(item);
                //         io.sockets.in(channel).emit('recMsg', {comment:item});
                //     });
                //     console.log("소켓입장확인");
                //     let msg={msg:socket.handshake.address+"님이 "+channel+" 채널에 입장하셨습니다.",userid:data.userid};
                //     console.log(msg);
                //     io.sockets.in(channel).emit('recMsg', {comment:msg});
                //     client.close();
                // });
            }
        });
    });

    socket.on('send', function (data) {
        let dataAddinfo = {ip: socket.handshake.address, msg: data.comment, date: Date.now(), userid:data.userid};
        console.log(dataAddinfo)
        MongoClient.connect('mongodb://localhost:27017/', function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('log').insert({
                    ip: dataAddinfo.ip,
                    msg: dataAddinfo.msg,
                    date: dataAddinfo.date,
                    channel: data.channel,
                    userid: dataAddinfo.userid
                }, function (err, doc) {
                    if (err) console.log(err);
                    client.close();
                });
            }
        });
        io.sockets.in(data.channel).emit('recMsg', {comment: dataAddinfo});
    });

    socket.on('reqMsg', function (data) {
        console.log(data);
        io.sockets.in(channel).emit('recMsg', {comment : data.comment+'\n'});
    })
});

/*소켓 연결 부분 */

/*업로드 부분*/

var multer = require('multer'); // multer모듈 적용 (for 파일업로드)
var storage = multer.diskStorage({
    destination: function (req, file, cb) {
        cb(null, 'uploads/') // cb 콜백함수를 통해 전송된 파일 저장 디렉토리 설정
    },
    filename: function (req, file, cb) {
        cb(null, file.originalname) // cb 콜백함수를 통해 전송된 파일 이름 설정
    }
})
var upload = multer({ storage: storage })

app.use('/down', express.static('uploads')); // express를 통한 경로
app.post('/upload', upload.single('userfile'), function(req, res){
    res.send('Uploaded! : '+req.file); // object를 리턴함
    console.log(req.file); // 콘솔(터미널)을 통해서 req.file Object 내용 확인 가능.
});
/*업로드 부분*/


app.use(bodyparser.urlencoded({extended : true}));
app.use(bodyparser.json())

const login_out = require('./login_out/login_out');
app.use("/",login_out);

const user = require('./user/user');
app.use("/user",user);

app.listen(50000,()=>{});