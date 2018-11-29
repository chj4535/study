<template>
    <div>
        hello {{id}}
    </div>
</template>

<script>
    export default {
        name: "Post",
        data(){
            console.log(1)
            return{
            };
        },
        computed: {
            id() {
                return this.$route.params.id
            }
        }
    }
</script>