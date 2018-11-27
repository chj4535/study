/*
* 참고 자료 : https://wayhome25.github.io/nodejs/2017/02/21/nodejs-15-file-upload/
*/

const express = require('express');
const app = express();
const bodyparser = require('body-parser');
app.use(bodyparser.urlencoded({extended : true}));
app.use(bodyparser.json())

app.get('/upload', function(req, res){
    res.render(upload);
});

// var multer = require('multer'); // express에 multer모듈 적용 (for 파일업로드)
// var upload = multer({ dest: 'uploads/' })
// // 입력한 파일이 uploads/ 폴더 내에 저장된다.
// // multer라는 모듈이 함수라서 함수에 옵션을 줘서 실행을 시키면, 해당 함수는 미들웨어를 리턴한다.

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

app.use('/users', express.static('uploads'));
app.post('/upload', upload.single('userfile'), function(req, res){
    res.send('Uploaded! : '+req.file); // object를 리턴함
    console.log(req.file); // 콘솔(터미널)을 통해서 req.file Object 내용 확인 가능.
});

app.listen(3000,()=>{});