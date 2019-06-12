import Vue from 'vue'
import Router from 'vue-router'
import POST from './views/Post'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
      {
        path:"/post/:id",
          name:"POST",
          component:POST
      }
  ]
})
