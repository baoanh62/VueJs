<script setup lang="ts">
import ToDoList from './ToDoList.vue';
</script>

<template>
    <div class="content-component">
        <h1>Todo</h1>
        <ToDoList/>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from 'vue';

    type Forecasts = {
        date: string,
        temperatureC: string,
        temperatureF: string,
        summary: string
    }[];

    interface Data {
        loading: boolean,
        post: null | Forecasts
    }

    export default defineComponent({
        data(): Data {
            return {
                loading: false,
                post: null
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            this.fetchData();
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            fetchData(): void {
                this.post = null;
                this.loading = true;

                fetch('weatherforecast')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json as Forecasts;
                        this.loading = false;
                        return;
                    });
            }
        },
    });
</script>

<style scoped>
th {
    font-weight: bold;
}
tr:nth-child(even) {
    background: #F2F2F2;
}

tr:nth-child(odd) {
    background: #FFF;
}

th, td {
    padding-left: .5rem;
    padding-right: .5rem;
}

.content-component {
    text-align: center;
}

table {
    margin-left: auto;
    margin-right: auto;
}
</style>