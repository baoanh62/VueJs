<script setup lang="ts">
import ToDoItem from './ToDoItem.vue'
import imgBG from "../assets/imagebg.png"
</script>

<template>
    <div class="todoList">
        <ToDoItem v-for="item in toDoList" :key="item.title" 
            :imageurl="item.imagePath ? item.imagePath : imgBG"
            @stat-task="onStartTask"
            @remove-task="onRemoveTask">
            <template #title>{{ item.title }}</template>
            <template #description>{{ item.description }}</template>
        </ToDoItem>
    </div>
</template>


<script lang="ts">
import { defineComponent } from 'vue';

interface ToDoItem {
    title: string,
    description: string,
    imagePath: null | string,
    isDeleted: boolean,
    start: boolean
};

interface Data {
    loading: boolean,
    toDoList: ToDoItem[]
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
        onStartTask(): void{
            alert("Comming Soon");
        },
        onRemoveTask(): void{
            alert("Comming Soon");
        },
        fetchData(): void {
            this.toDoList = [];
            this.loading = true;
            fetch('https://localhost:7281/Todo')
                .then(r => r.json())
                .then(json => {
                    this.toDoList = json as ToDoItem[];
                    this.loading = false;
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
    flex-direction: row;
    justify-content: center;
}
</style>