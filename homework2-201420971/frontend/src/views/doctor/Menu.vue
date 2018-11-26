<template>
    <div class="Menu">
        <div><h1>Doctor Menu</h1></div>

        <div>
            <h2>New Doctor</h2><br>
            <form @submit.prevent="newDoctor">
                name
                <input type="text" name="name" v-model="new_doctor_name"/>
                office
                <input type="text" name="office" v-model="new_doctor_office"/>
                <input type="submit" value="Add"/>
            </form>
        </div>

        <div>
            <h2>Call Patient</h2>
            <form @submit.prevent="CallPatient">
                Doctor's Name
                <input type="text" name="name" v-model="doctor_name"/>
                <input type="submit" value="Call"/>
            </form>
        </div>

        <div>
            <h2>Terminate Treatment</h2>
            <form @submit.prevent="Terminate">
                Waiting Number
                <input type="number" name="number" v-model="patient_number"/>
                <input type="submit" value="terminate"/>
            </form>
        </div>

        <div>
            <h2>Doctor List</h2>
            <div v-for="item in list">
                <p>
                    {{item.name}} - {{item.office}}
                </p>
            </div>
        </div>

        <div>
            <button v-on:click="getlist">reflesh</button>
        </div>
    </div>
</template>

<script>
    export default {
        data(){
            return {
                list:[],
                new_doctor_name:'',
                new_doctor_office:'',
                doctor_name:'',
                patient_number:''
            }
        },
        created: function(){
            this.axios.get('http://localhost:8000/doctor/list').then((res) => {
                this.list=res.data;
            })
        },
        methods:{
            Terminate:function(){
                this.axios.get('http://localhost:8000/doctor/done/'+this.patient_number).then((res) => {
                })
                this.patient_number='';
            },
            CallPatient:function(){
                this.axios.get('http://localhost:8000/doctor/call/'+this.doctor_name).then((res) => {
                })
                this.doctor_name='';
            },
            newDoctor:function () {
                this.axios.post('http://localhost:8000/doctor/register',{
                    name:this.new_doctor_name,
                    office:this.new_doctor_office
                }).then((res) => {
                })
                this.new_doctor_name='';
                this.new_doctor_office='';
            },
            getlist:function () {
                this.axios.get('http://localhost:8000/doctor/list').then((res) => {
                    this.list=res.data;
                })
            }
        }
    }
</script>