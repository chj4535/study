const express = require('express');
const fs = require('fs');
const user = express();
const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

var param=new Object();

user.use("/:userid",(req,res,next)=>{
    console.log("user 진입");
    param['userid']=req.params.userid;
    MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
        if (error) console.log(error);
        else {
            const db = client.db(dbName);
            db.collection('userinfo').find({userid:param['userid']}).toArray(function(err,doc){
                if (error) console.log(error);
                else{
                    console.log(doc.toString())
                    if (doc.toString()!=''){
                        console.log('유저 정보 확인! ')
                        param['email']=doc[0].email;
                        console.log(param['email']);
                    }
                }
            });
        }
    });
    next();
})

user.post("/",(req,res)=>{//유저 생성

    console.log('유저 로그인')
    var json = Object.keys(req.body);
    var jspar = (JSON.parse(json));

    console.log(req.body);
    console.log('0번방 :' + json[0]);
    console.log(jspar.userid)
    console.log(jspar.username)

    MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
        if (error) console.log(error);
        else {
            const db = client.db(dbName);
            db.collection('userinfo').find({userid:jspar.userid}).toArray(function(err,doc){
                if (error) console.log(error);
                else{
                    console.log(doc.toString())
                    if (doc.toString()==''){
                        console.log('유저 정보 없음! 생성')
                        db.collection('userinfo').insert(jspar);
                    }
                }
            });
        }
    });
    res.end('');
});

user.get("/:userid",(req,res)=>{ //그룹 조회
	console.log('uid: ',param['userid']);
    var html='에러';
    MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
        if (error) console.log(error);
        else {
            const db = client.db(dbName);
            db.collection('groups').find({}).toArray(async function(err,doc){
                if (err) console.log(err);
                else{
                    var num=0;
                    var numfind=0;
                    var jsa = new Array();
                    console.log(doc.length)
                    numfind=doc.length;
                    await doc.forEach((item)=>{
                        var list=item.invitedUsers;
                        console.log('list: ',list);
                        for(var i=0;i<list.length;i++){
                            // console.log('현재 이메일 : '+param['email'],'조회 이메일 : '+list[i].email);
                            if(list[i].email==param['email']){
                                jsa.push(item);
                                // console.log('그룹 단일 조회 jsa : ',jsa);
                                break;
                            }
                        }
                    });
                    // await console.log('그룹 조회 jsa : ',jsa);
                    await res.send(jsa);
                }
            });
        }
    });
});

user.delete("/",(req,res)=>{//유저 삭제

    console.log('유저 삭제')
    console.log(param['userid'])
    var json = Object.keys(req.body);
    var jspar = (JSON.parse(json));

    console.log(req.body);
    console.log('0번방 :' + json[0]);
    console.log(jspar.userid)
    console.log(jspar.username)

    MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
        if (error) console.log(error);
        else {
            const db = client.db(dbName);
            console.log(jspar);
            db.collection('userinfo').remove(jspar);
        }
    });
});


const group = require('./group/group')(param);
user.use("/:userid/group",group);

const board = require('./board/board')(param);
user.use("/:userid/board",board);


module.exports = user;


/*
MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
        if (error) console.log(error);
        else {
            const db = client.db(dbName);
            db.collection('groupmember').find({groupuserid:param['userid']}).toArray(function(err,doc){
                if (err) console.log(err);
                else{
                    var num=0;
                    var numfind=0;
                    var jsa = new Array();
                    console.log(doc.length)
                    numfind=doc.length;
                    doc.forEach((item)=>{
                        db.collection('groups').findOne({groupid:item.groupid},function (err,group_res) {
                            if(err)console.log(err)
                            else {
                                console.log(group_res);
                                jsa.push(group_res);
                                console.log('result :', jsa);
                                if (jsa.length == numfind) {
                                    console.log('final : ', jsa)
                                    res.send(jsa)
                                }
                            }
                        })
                    });
                }
            });
        }
    });
 */