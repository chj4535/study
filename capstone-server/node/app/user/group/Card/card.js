const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

module.exports = function (param) {

    const express = require('express');
    const card = express.Router();

    card.use("/", (req, res, next) => {
        console.log("card 진입");
        next();
    })

    card.get("/", (req, res) => {//카드 조회
        console.log("card 조회!");
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('card').find({groupid: param['groupid']}).toArray(function(err,doc) {
                    if(err){
                        console.log(err);
                    }
                    else{
                        console.log(doc)
                        console.log(doc[0])
                        console.log(doc[0]._id)
                        res.send(doc);
                    }
                })
            }
        });
    });

    card.put("/", (req, res) => {//카드 추가
        console.log("card 추가!");
        let card_item;
        var ObjectID = require('mongodb').ObjectID;
        console.log(req.body);
        card_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                var _id = card_item._id;
                delete card_item._id;
                console.log(card_item);
                console.log("수정내역: "+card_item.name);
                console.log("수정내역: "+card_item.Year);
                console.log("수정내역: "+card_item.Month);
                console.log("수정내역: "+card_item.dayOfMonth);
                console.log("수정내역: "+card_item.startTime);
                console.log("수정내역: "+card_item.endTime);
                console.log("수정내역: "+card_item.color);
                console.log("수정내역: "+card_item.comment);
                db.collection('card').update({_id:ObjectID(_id)},{$set:{
                    name:card_item.name,
                    Year:card_item.Year,
                    Month:card_item.Month,
                    dayOfMonth:card_item.dayOfMonth,
                    startTime:card_item.startTime,
                    endTime:card_item.endTime,
                    color:card_item.color,
                    comment:card_item.comment
                }});
            }
        });
        res.send(200);
    });

    card.post("/", (req, res) => {//카드 추가
        console.log("card 추가!");
        let card_item;
        console.log(req.body);
        card_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                Object.assign(card_item,{groupid:param['groupid']});
                db.collection('card').insert(card_item);
            }
        });
    });
    
    card.delete("/", (req, res) => {//카드 수정
        console.log("card 수정!");
        let card_items;
        console.log(req.body);
        card_items=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('card').deleteMany({groupid:param['groupid']},function (err,client) {
                    if(err) console.log(err);
                    else{
                        card_items.forEach((card_item)=>{
                            console.log(card_item);
                            Object.assign(card_item,{groupid:param['groupid']});
                            db.collection('card').insert(card_item);
                        });
                    }
                })
            }
        });
    });

    return card;
};