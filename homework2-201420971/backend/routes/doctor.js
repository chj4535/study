const { Router } = require('Express')
const doctorModel = require('../db/models/doctor')
const patientModel = require('../db/models/patient')

const router = Router()

router.post('/register',function (req,res) {
    console.log('/doctor/register 입장');
    console.log(req.body.name);
    console.log(req.body.office);
    console.log(req.body.password);
});

router.get('/call/:doctorName',function (req,res) {
    console.log('/doctor/call/:doctorName 입장');
    console.log(req.params.doctorName);
});

router.get('/done/:patientId',function (req,res) {
    console.log('/doctor/done/:patientId 입장');
    console.log(req.params.patientId);
});

router.get('/list',function (req,res) {
    console.log('/doctor/list 입장');
});



module.exports = router