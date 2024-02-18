<script setup lang="ts">
import Home from './components/Home.vue';
import NavBar from './components/NavBar.vue';
</script>

<template>
  <header>
    <NavBar/>
    <div class="wrapper">
     
    </div>
  </header>

  <main>
    <Home />
  </main>
</template>

<style scoped>
header {
  display: flex;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    place-items: center;
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
