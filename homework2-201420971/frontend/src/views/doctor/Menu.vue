<template>
    <div class="Menu">
        <div><h1>Doctor Menu</h1></div>

        <div>
            <h2>New Doctor</h2><br>
            <form>
                name
                <input type="text" name="name"/>
                office
                <input type="text" name="office"/>
                <input type="submit" value="Add"/>
            </form>
        </div>

        <div>
            <h2>Call Patient</h2>
            <form>
                Doctor's Name
                <input type="text" name="name"/>
                <input type="submit" value="Call"/>
            </form>
        </div>

        <div>
            <h2>Terminate Treatment</h2>
            <form>
                Waiting Number
                <input type="number" name="number"/>
                <input type="submit" value="terminate"/>
            </form>
        </div>

        <div>
            <h2>Doctor List</h2>
        </div>

        <div>
            <button>reflesh</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: "Menu"
    }
</script>

<style scoped>

</style>