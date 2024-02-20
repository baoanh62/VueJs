<script setup lang="ts">
import CompanyItem from './CompanyNew.vue'
import imgBG from "../assets/imagebg.png"
</script>

<template>
    <div class="todoList">
        <CompanyItem v-for="item in toDoList" :key="item.title" 
            :imageurl="item.imagePath ? item.imagePath : imgBG">
            <template #title>{{ item.title }}</template>
            <template #description>{{ item.description }}</template>
        </CompanyItem>
    </div>
</template>


<script lang="ts">
import { defineComponent } from 'vue';

interface CompanyItem {
    title: string,
    description: string,
    imagePath: null | string,
    isDeleted: boolean,
    start: boolean
};

interface Data {
    loading: boolean,
    toDoList: CompanyItem[]
}

export default defineComponent({
    data(): Data {
        return {
            loading: false,
            toDoList: []
        };
    },
    created() {
        this.fetchData();
    },
    watch: {
    },
    methods: {
        fetchData(): void {
            this.toDoList = [];
            this.loading = true;
            fetch('https://localhost:7281/Todo')
                .then(r => r.json())
                .then(json => {
                    this.toDoList = json as CompanyItem[];
                    this.loading = false;
                    console.log(this.toDoList);
                    return;
                });
        }
    },
});
</script>


<style scoped>
.todoList {
    display: flex;
    flex-wrap: wrap;
    flex-direction: column;
    justify-content: center;
    width: 100%;
    align-items: center;
}
</style>