<template>
    <li class="nav-item" v-bind:class="active ? 'active' : ''">
        <a class="nav-link" v-bind:href="url">
            <div class="item">
                <div class="content">
                    <i>
                        <slot name="icon"></slot>
                    </i>
                    <slot name="heading"></slot>
                </div>
                <div class="notify" v-if="$slots['count']">
                    <slot name="count"></slot>
                </div>
            </div>
        </a>
    </li>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
    props: ['url', 'active'],
    data() {
        return {
            propUrl: this.url,
            propActive: this.active
        }
    }
});
</script>

<style scoped>
.nav-item {
    color: black;
}

.nav-item:hover{
    background-color: #ffffff;
}

.nav-item.active{
    background-color: #ffffff;
}

.nav-item .notify {
    border-radius: 50%;
    background-color: #f07771;
    width: 30px;
    font-size: 12px;
    font-weight: bold;
    text-align: center;
    padding-top: 2px;
}

.nav-item .item {
    display: flex;
    justify-content: space-between;
}

.nav-item .content {
    display: flex;
    justify-content: center;
    width: 120px;
}

@media (max-width: 1224px) {
    .nav-item .content {
        justify-content: center;
        width: 85px;
    }

    .nav-item .notify {
        width: 25px;
        font-size: 10px;
    }

}

@media (max-width: 1000px) {
    .nav-item .item {
        justify-content: flex-start;
    }
}
</style>