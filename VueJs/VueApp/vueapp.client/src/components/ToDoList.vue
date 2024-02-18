<script setup lang="ts">
import ToDoItem from './ToDoItem.vue'
import DocumentationIcon from './icons/IconDocumentation.vue'
import ToolingIcon from './icons/IconTooling.vue'
import EcosystemIcon from './icons/IconEcosystem.vue'
import CommunityIcon from './icons/IconCommunity.vue'
import SupportIcon from './icons/IconSupport.vue'
</script>

<template>
    <ToDoItem v-for="item in toDoList" :key="item.title">

    </ToDoItem>
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
        fetchData(): void {
            this.toDoList = [];
            this.loading = true;

            fetch('https://localhost:7281/Todo')
                .then(r => r.json())
                .then(json => {
                    this.toDoList = json as ToDoItem[];
                    this.loading = false;
                    console.log(this.toDoList);
                    return;
                });
        }
    },
});
</script>