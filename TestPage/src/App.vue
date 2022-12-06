<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <!-- <header>
    <nav class="">
        <RouterLink to="/">TURING-IA</RouterLink>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/about">About</RouterLink>
        <RouterLink to="/services">Services</RouterLink>
      </nav>

  </header> -->
<div class="cotainer">
  <nav class="navbar navbar-expand-sm bg-light">
      <div class="container-fluid">
        <a class="navbar-brand" href="#">TURING-IA</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavDropdown">
          <ul class="navbar-nav">
            <li class="nav-item">
              <RouterLink class="nav-link active" aria-current="page" to="/" >Inicio</RouterLink>
            </li>
            <li class="nav-item">
              <RouterLink class="nav-link" to="/about">Nosotros</RouterLink>
            </li>
            <li class="nav-item">
              <RouterLink class="nav-link" to="/services">Servicios</RouterLink>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                Tableau
              </a>
              <ul class="dropdown-menu">
                <li><a class="dropdown-item" href="#">Action</a></li>
                <li><a class="dropdown-item" href="#">Another action</a></li>
                <li><a class="dropdown-item" href="#">Something else here</a></li>
              </ul>
            </li>
            <li>
            <a class="nav-link " aria-current="page" href="https://www.turing-ia.com/portal/" >Portal</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <RouterView />
</div>
</template>

<style scoped>
  .cotainer{
    display: block;
  }
</style>
