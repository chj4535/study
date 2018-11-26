const { Router } = require('Express')
const router = Router()
const patientModel = require('../db/models/patient')

router.post('/register',function (req,res) {
    console.log('/patient/register 입장');
    console.log(req.body.name);
    patientModel.create({name:req.body.name,isCalled:'no',Office:''},function (err,result) {
       if(err) return console.log(err);
       else{
           res.send('');
       }
    });
});

router.get('/list',function (req,res) {
    console.log('/patient/list 입장');
    try {
        patientModel.find({},function (err,docs) {
            console.log(docs);
            res.send(docs);
        });
    }catch(err){
        console.log(err)
    }
});

module.exports = router