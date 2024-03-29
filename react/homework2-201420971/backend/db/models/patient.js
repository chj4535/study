const { mongoose, autoIncrement } = require('../mongo')

const patientSchema = new mongoose.Schema({
    patientId: {
        type: Number,
        unique: true
    },
    name: {
        type: String
    },
    isCalled: {
        type: String
    },
    Office: {
        type: String
    }
    /* ... */
})

// patientId 를 Auto Increment 필드로 지정
patientSchema.plugin(autoIncrement, {
    model: 'Patient',
    field: 'patientId',
    startAt: 1001
})

module.exports = mongoose.model('Patient', patientSchema)