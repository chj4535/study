const express = require('express');
const path = require('path');
const os = require("os");
var bodyParser = require('body-parser')

var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";
MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  console.log("Database created!");
  db.close();
});

const app = express();
const PORT = process.env.PORT || 4000;

app.use(express.static(path.join(__dirname, '..', 'public/')));
app.use(bodyParser.urlencoded({extended:true}));
app.use(bodyParser.json());

// if you need api routes add them here
app.post("/getdata", function(req, res){
  console.log(req.body.data);
  res.send(200);
});

app.listen(PORT, () => {
console.log(`Check out the app at http://localhost:${PORT}`);
});
