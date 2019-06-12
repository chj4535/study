<template>
    <div style="text-align: center">
        {{posting}}
        <h1>{{post.title}}</h1>
        <p>{{post.content}}</p>
    </div>
</template>

<script>
    export default {
        name: "Post",
        data(){
            return{
                post:{}
            };
        },
        asyncComputed:{
            async posting(){
                const res = await this.$http.get('http://localhost:8000/post/'+this.$route.params.id);
                this.post =  res.data;
            }
        }
    }
</script>