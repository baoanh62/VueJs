<script setup lang="ts">
import DocumentationIcon from './icons/IconDocumentation.vue'
import ToolingIcon from './icons/IconTooling.vue'
import EcosystemIcon from './icons/IconEcosystem.vue'
import CommunityIcon from './icons/IconCommunity.vue'
import SupportIcon from './icons/IconSupport.vue'
</script>

<template>
  <div class="card">
    <img class="card-img-top" :src="imageurl" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title">
        <slot name="title"></slot>
      </h5>
      <span>Task description</span>
      <br/>
      <p class="card-text">
        <slot name="description"></slot>
      </p>
      <div class="action">
        <button type="button" v-on:click="startTaskClick" class="btn btn-primary">Start</button>
        <button type="button" v-on:click="removeTaskClick" class="btn btn-dark">Remove</button>
      </div>
    </div>
  </div>
</template>


<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  props: ['imageurl',],
  emits: ["statTask", "removeTask"],
  data() {
    return {
      propimageurl: this.imageurl
    }
  },
  methods: {
    startTaskClick() {
      this.$emit("statTask");
    },
    removeTaskClick() {
      this.$emit("removeTask");
    },
  }
});
</script>

<style scoped>
.card {
  width: 24rem;
  height: auto;
  margin-right: calc(2% + 5px);
  margin-bottom: calc(2% + 5px);
  text-align: left;
  background: black;
  color: white;
}

.card .card-img-top{
  padding: 4px;
}

.card .action {
  float: left;
}

.card button {
  height: 45px;
  width: 95px;
  margin-right: 10px;
}
</style>