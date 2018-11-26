<template>
  <div class="home">
    <div><h1>Homework2-201420971</h1></div>

    <div>
      <h2>New Patient</h2><br>
      <form>
        Your Name:
        <input type="text" name="name"/>
        <input type="submit" value="add"/>
      </form>
    </div>

    <div>
      <h2>Called Patients</h2>
    </div>

    <div>
      <h2>Pending Patients</h2>
      {{check}}
      {{check2}}
      {{check3}}
      <p v-for="item in list">
        {{item.patientId}}-{{item.name}}
      </p>
    </div>

    <div>
      <button>reflesh list</button>
    </div>
  </div>
</template>

<script>
  export default {
      data(){
          return {
              list:[],
          }
      },
      created: function(){
          this.axios.get('http://localhost:8000/patient/list').then((res) => {
              this.list=res.data;
          })
      }
  }
</script>
