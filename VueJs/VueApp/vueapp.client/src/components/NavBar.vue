<script setup lang="ts">
import NavBarItem from './NavBarItem.vue';
</script>
<template>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">
                <img alt="vue logo" class="logo" src="../assets/logo.svg" width="30" height="30" />
            </a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent"
                aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <NavBarItem v-for="item in navList" :key="item.link" :url="item.active ? 'javascript:void' : item.link" :active="item.active">
                        <template #heading>
                            {{ item.text }}
                        </template>
                        <template v-if="item.notify" #count>{{ item.notify }}</template>
                    </NavBarItem>
                </ul>

                <div class="d-flex">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <NavBarItem url="#">
                            <template #heading>
                                Tony Stark
                            </template>
                        </NavBarItem>
                        <NavBarItem url="logout">
                            <template #heading>
                                Log Out
                            </template>
                        </NavBarItem>
                    </ul>
                </div>
            </div>
        </div>
    </nav>
</template>


<script lang="ts">
import { defineComponent } from 'vue';

interface NavItem {
    link: string,
    text: string,
    notify: null | string,
    active: boolean
};

interface Data {
    loading: boolean,
    navList: NavItem[]
}

export default defineComponent({
    data(): Data {
        return {
            loading: false,
            navList: [
                { link: "stark", text: "Stark", notify: null, active: false },
                { link: "todo", text: "Todo", notify: '84', active: true },
                { link: "inprogress", text: " In Progress", notify: '42', active: false },
                { link: "completed", text: "Completed", notify: null, active: false },
            ]
        };
    },
    created() {
    },
    watch: {
    },
    methods: {

    },
});
</script>

<style scoped>
nav {
    width: 100%;
    height: 60px;
    background-color: #f0f0f0 !important;
}
#navbarSupportedContent{
    height: inherit;
}

.d-flex,
.container-fluid,
.navbar-nav,
.nav-item{
    display: inherit;
    height: inherit;
    align-items: center;
}

@media (max-width: 990px) {
    nav {
        height: auto;

    }
}
</style>