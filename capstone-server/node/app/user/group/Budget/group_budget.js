const mongodb =require('mongodb');
const MongoClient = mongodb.MongoClient;
const dbName = 'db';

module.exports = function (param) {

    const express = require('express');
    const budget = express.Router();

    budget.use("/", (req, res, next) => {
        console.log("group_budget 진입");
        next();
    })

    budget.get("/", (req, res) => {//예산 조회
        console.log("group_budget 조회!");
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('budget').find({groupid: param['groupid'], userid: param['userid']}).toArray(function(err,doc) {
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

    budget.post("/", (req, res) => {//예산 추가
        console.log("group_budget 추가!");
        let budget_item;
        console.log(req.body);
        budget_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                Object.assign(budget_item, {groupid: param['groupid'], userid: param['userid']}); //uid, groupid추가
                console.log('budgetitem : ', budget_item);
                db.collection('budget').insert(budget_item);
            }
        });
        res.send(' ');
    });

    budget.put("/", (req, res) => {//예산 추가
        console.log("group_budget 수정!");
        let budget_item;
        console.log(req.body);
        budget_item=req.body;
        MongoClient.connect('mongodb://localhost:27017/',  { useNewUrlParser: true }, function (error, client) {
            if (error) console.log(error);
            else {
                const db = client.db(dbName);
                db.collection('budget').updateOne({time:budget_item.time},{$set:{item:budget_item.item,price:budget_item.price}});
            }
        });
        res.send(' ');
    });


    return budget;
};