const { Router } = require('Express')
const doctorModel = require('../db/models/doctor')
const patientModel = require('../db/models/patient')

const router = Router()

router.post('/register',function (req,res) {
    console.log('/doctor/register 입장');
    console.log(req.body.name);
    console.log(req.body.office);
    doctorModel.create({name:req.body.name,office:req.body.office},function (err,result) {
        if(err) return console.log(err);
        else{
            res.send('');
        }
    });
});

router.get('/call/:doctorName',function (req,res) {
    console.log('/doctor/call/:doctorName 입장');
    console.log(req.params.doctorName);
    doctorModel.findOne({name:req.params.doctorName},function(err,doc){
       var office = doc.office;
       console.log(office);
       patientModel.findOne({isCalled:'No'},function (err,doc) {
           var id = doc.patientId;
           console.log(id);
           doc.set({Office:office, isCalled:'Called'});
           doc.save(function (err,resq) {
               if(err) console.log(err);
               else res.send('');
           });
       });
    });
});

router.get('/done/:patientId',function (req,res) {
    console.log('/doctor/done/:patientId 입장');
    console.log(req.params.patientId);
    patientModel.findOne({patientId: Number(req.params.patientId)},function (err,doc) {
        var id = doc.patientId;
        console.log(id);
        doc.set({isCalled:'Done'});
        doc.save(function (err,resq) {
            if(err) console.log(err);
            else res.send('');
        });
    });
});

router.get('/list',function (req,res) {
    console.log('/doctor/list 입장');
    try {
        doctorModel.find({},function (err,docs) {
            console.log(docs);
            res.send(docs);
        });
    }catch(err){
        console.log(err)
    }
});



module.exports = router