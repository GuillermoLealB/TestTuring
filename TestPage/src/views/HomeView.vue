<script setup>
  import InformationHome from '../components/InformationHome.vue'
  import SliceHome from '../components/SliceHome.vue'
</script>

<template>
  <div class="container-home">
    <div class="text-tittle-container">
      <div class="tittle-1">Bienvenido</div>
      <div class="tittle-2">Hacemos los datos fáciles de usar</div>
    </div>
  </div>
  <section>
    <div class="home-section--1">
      <div><img class="img-section-1" src="../assets/Images/HomeImages/pexels-fauxels-3183153.jpg" alt="" srcset=""></div>
    <div class="description">
      <h5 style="text-align: left;">Nuestro trabajo</h5>
      <h2>Contribuimos con su empresa para mejorar la toma de decisiones a través de sus datos.</h2>
      <button type="button" class="btn btn-dark">Información</button>
    </div>
  </div>
  </section>
  <section>
    <InformationHome/>
  </section>
  <section>
    <div class="swiper-home">
      <SliceHome />
    </div>
  </section>
</template>

<style scoped>

.container-home{
  background-image: linear-gradient(rgba(0, 0, 0, 0.637),rgba(0, 0, 0, 0.473)),url("../assets/Images/pexels-andrea-piacquadio-840996.jpg");
  background-position: center ;
  background-size: cover;
  position: relative;
  display: flex;
 height: 40rem;
 overflow: hidden;
}



.home-section--1{
  padding: 4rem 1rem;
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
  z-index: 10;
}
.img-section-1{
  clip-path: polygon(25% 0%, 100% 0%, 75% 100%, 0% 100%);
  height: 20rem;
  width: 25rem;
 
}


.description{
  font-size: 1.5rem;
  padding: 50px 0;
  text-align: center;
  margin: auto;
  width: 55%;


}
.swiper-home{
  height:100% ;
}




</style>
