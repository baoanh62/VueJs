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
      <p class="card-text">
        <slot name="description"></slot>
      </p>
    </div>
  </div>
</template>


<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  props: ['imageurl',],
  data() {
    return {
      propimageurl: this.imageurl
    }
  },
  methods: {
  }
});
</script>

<style scoped>
.card {
  height: auto;
  margin-right: calc(2% + 5px);
  margin-bottom: calc(2% + 5px);
  text-align: left;
  background: black;
  color: white;
  display: flex;
  flex-direction: row;
  max-width: 1000px;
}

.card:nth-child(even) {
    flex-direction: row-reverse;
}

.card .card-img-top{
  padding: 4px;
  width: 480px;
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