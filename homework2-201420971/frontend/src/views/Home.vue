<template>
  <div class="home">
    <div><h1>Homework2-201420971</h1></div>

    <div>
      <h2>New Patient</h2><br>
      <form @submit.prevent="newPatient">
        Your Name:
        <input type="text" name="name" v-model="new_patient_name"/>
        <input type="submit" value="add"/>
      </form>
    </div>

    <div>
      <h2>Called Patients</h2>
      <div v-for="item in list">
        <p v-if="item.isCalled==='Called'">
          {{item.patientId}}번 환자 - {{item.Office}}
        </p>
      </div>
    </div>

    <div>
      <h2>Pending Patients</h2>
      <div v-for="item in list">
        <p v-if="item.isCalled==='No'">
          {{item.patientId}} - {{item.name}}
        </p>
      </div>
    </div>

    <div>
      <button v-on:click="getlist">reflesh list</button>
    </div>
  </div>
</template>

<script>
  export default {
      data(){
          return {
              new_patient_name:'',
              list:[],
          }
      },
      created: async function(){
          await this.axios.get('http://localhost:8000/patient/list').t
      },
      methods:{
          newPatient:function() {
              this.axios.post('http://localhost:8000/patient/register',{
                  name:this.new_patient_name
              }).then((res) => {
              })
              this.new_patient_name='';
          },
          getlist:function () {
              this.axios.get('http://localhost:8000/patient/list').then((res) => {
                  this.list=res.data;
              })
          }
      }
  }
</script>
