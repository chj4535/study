const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

module.exports = function (param) {

    const express = require('express');
    const gbudget = express.Router();

    gbudget.use("/", (req, res, next) => {
        console.log("group_gbudget 진입");
        next();
    })

    gbudget.get("/", (req, res) => {//예산 조회
        console.log("group_gbudget 조회!");
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('gbudget').find({groupid: param['groupid']}).toArray(async function(err,doc) {
                    if(err){
                        console.log('no!');
                    }
                    else{
                        res.send(doc);
                    }
                })
            }
        });
    });

    gbudget.post("/", (req, res) => {//예산 추가
        console.log("group_gbudget 추가!");
        let budget_item;
        console.log(req.body);
        budget_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                Object.assign(budget_item, {groupid: param['groupid']}); //uid, groupid추가
                console.log('budgetitem : ', budget_item);
                db.collection('gbudget').insert(budget_item);
            }
        });
        res.send(' ');
    });

    gbudget.put("/", (req, res) => {//예산 추가
        console.log("group_budget 수정!");
        let budget_item;
        console.log(req.body);
        budget_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('gbudget').updateOne({time:budget_item.time},{$set:{item:budget_item.item,price:budget_item.price}});
            }
        });
        res.send(' ');
    });

    return gbudget;
};