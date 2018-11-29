<template>
  <div id="app">
    <div id="nav">
      <ul>

        <li v-for="item in list" :key="item.id">
          <router-link :to="{name:'POST', params:{id:item.id}}">{{item.title}}</router-link>
        </li>
      </ul>
    </div>
    <router-view/>
  </div>
</template>

<script>
    export default {
        data(){
            return {
                list:[]
            }
        },
        created: async function(){
            var res = await this.$http.get('http://localhost:8000/post');
            this.list=res.data;
        }
    }
</script>