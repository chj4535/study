import Vue from 'vue'
import App from './App.vue'
import router from './router'
import axios from 'axios'
import VueAxios from 'vue-axios'
import AsyncComputed from 'vue-async-computed'


Vue.config.productionTip = false;
Vue.prototype.$http = axios;

new Vue({
    router,
    render: h => h(App)
}).$mount('#app')

Vue.use(VueAxios, axios);
Vue.use(AsyncComputed);