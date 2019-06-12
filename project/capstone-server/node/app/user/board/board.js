const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

module.exports = function (param) {

    const express = require('express');
    const board = express.Router();
    const fs = require('fs');

    board.use("/", (req, res, next) => {
        console.log("group 진입");
        next();
    })

    board.use("/:boardid", (req, res, next) => {
        param['boardid'] = req.params.boardid;
        next();
    })

    board.get("/", (req, res) => {//글 조회
        var html='에러';
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('board').find().toArray(function(err,doc){
                    if (err) console.log(err);
                    if (doc.toString()==''){
                        console.log(doc.toString());
                        res.writeHead(200, {'Content-Type': 'text/plain; charset=utf-8'});//한글 깨짐 방지용
                        res.end(html);
                    }
                    else {
                        console.log(doc);
                        res.json(doc);
                    }
                });
            }
        });
    });

    board.post("/", (req, res) => {//글 생성
        console.log('글 생성 진입')
        var nowboardnum;
        var json = Object.keys(req.body);
        var jspar = (JSON.parse(json));

        console.log(jspar)
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('numcheck').findOne(function(err,doc){
                    if (err) console.log(err);
                    else {
                        nowboardnum = doc["boardnum"];
                        console.log(jspar.userid)
                        db.collection('userinfo').find({userid:jspar.userid}).toArray(function (err,userdoc) {
                            console.log("find:",userdoc)
                            data=userdoc[0]
                            console.log(data.userid)
                            Object.assign(jspar,{boardid:nowboardnum+1,user:data.username});
                            db.collection('board').insert(jspar);
                        });
                        res.send('')
                    }
                });
            }
        });
    });

    board.get("/:boardid", (req, res) => {//글 선택
        var html='에러';
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('board').findOne({boardid:param['boardid']}, function(err,doc){
                    if (err) console.log(err);
                    if (doc.toString()==''){
                        console.log(doc.toString());
                        res.writeHead(200, {'Content-Type': 'text/plain; charset=utf-8'});//한글 깨짐 방지용
                        res.end(html);
                    }
                    else {
                        console.log(doc);
                        res.json(doc);
                    }
                });
            }
        });
    });

    return board;
};