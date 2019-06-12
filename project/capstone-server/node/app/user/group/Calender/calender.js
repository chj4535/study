const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

module.exports = function (param) {

    const express = require('express');
    const calender = express.Router();

    calender.use("/", (req, res, next) => {
        console.log("calender 진입");
        next();
    })

    calender.get("/", (req, res) => {//일정 조회
        console.log("calender 조회!");
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('calender').find({groupid: param['groupid']}).toArray(function(err,doc) {
                    if(err){
                        console.log(err);
                    }
                    else{
                        res.send(doc);
                    }
                })
            }
        });
    });

    calender.delete("/", (req, res) => {//일정 수정
        console.log("calender 수정!");
        let calender_items;
        console.log(req.body);
        calender_items=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('calender').deleteMany({groupid:param['groupid']},function (err,client) {
                    if(err) console.log(err);
                    else{
                        calender_items.forEach((calender_item)=>{
                            console.log(calender_item);
                            Object.assign(calender_item,{groupid:param['groupid']});
                            db.collection('calender').insert(calender_item);
                        });
                    }
                })
            }
        });
        res.send(200);
    });

    return calender;
};