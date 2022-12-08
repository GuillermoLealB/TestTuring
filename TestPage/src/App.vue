<script setup>
import { RouterLink, RouterView } from "vue-router";
import FooterPage from "./components/FooterPage.vue";
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

  <nav class="navbar navbar-expand-lg fixed-top ">
    <div class="container-nav">
      <div>
        <a class="navbar-brand" href="#"> <b>TURING-IA</b> </a>
      </div>
      <div class="navbar-dark">
        <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight"
          aria-controls="offcanvasRight">
          <!-- class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvas" aria-controls="offcanvas" aria-expanded="true" aria-label="Toggle navigation" -->
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="offcanvas offcanvas-end text-bg-dark" tabindex="-1" id="offcanvasRight"
          aria-labelledby="offcanvasRightLabel">
          <div class="offcanvas-header">
            <h5 class="offcanvas-title" id="offcanvasExampleLabel">MENU</h5>
            <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
          </div>
          <ul class="navbar-nav">
            <li class="nav-item" type="button" data-bs-dismiss="offcanvas" aria-label="Close">
              <RouterLink to="/" class="nav-link" aria-current="page">Inicio</RouterLink>
            </li>
            <li class="nav-item" type="button" data-bs-dismiss="offcanvas" aria-label="Close">
              <RouterLink class="nav-link" to="/about">Nosotros</RouterLink>
            </li>
            <li class="nav-item" type="button" data-bs-dismiss="offcanvas" aria-label="Close">
              <RouterLink class="nav-link" to="/services">Servicios</RouterLink>
            </li>
            <li class="nav-item dropdown">
              <div class="btn-group twonav">
                <div type="button" data-bs-dismiss="offcanvas" aria-label="Close">
                  <RouterLink class="nav-link" to="/tableau">
                    Tableau
                  </RouterLink>
                </div>
                <div role="button" class="nav-link dropdown-toggle dropdown-toggle-split" data-bs-toggle="dropdown"
                  aria-expanded="false">
                  <span class="visually-hidden">Toggle Dropdown</span>
                </div>
                <ul class="dropdown-menu">
                  <li><a class="dropdown-item" href="#">Action</a></li>
                  <li><a class="dropdown-item" href="#">Another action</a></li>
                  <li>
                    <a class="dropdown-item" href="#">Something else here</a>
                  </li>
                </ul>
              </div>
            </li>
            <li class="nav-item" type="button" data-bs-dismiss="offcanvas" aria-label="Close">
              <a class="nav-link" aria-current="page" href="https://www.turing-ia.com/portal/">Portal</a>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </nav>


  <RouterView class="viwes" />

  <FooterPage />
</template>

<style scoped>
.navbar {
  display: block;
}

.navbar-brand {
  color: var(--font-links-bar);
  font-size: 2rem;
}

.nav-item {
  padding: 1.5rem;
  font-size: 1.2rem;
  padding: 0 2%;
  text-align: center;
}

.nav-link {
  color: var(--font-links-bar);
}

.container-nav {
  display: flex;
  justify-content: space-around;



}

.collapse {}

.viwes {
  z-index: 1;
}

.twonav:hover {}
</style>
