<script setup>
import CardsCertifications from "../components/services-Component/CardsCertifications.vue";
</script>

<template>
  <div class="container-home">
    <div class="text-tittle-container">
      <div class="tittle-1">Nosotros</div>
      <div class="tittle-2">
        Somos Especialistas en Proyectos de Business Analytics
      </div>
    </div>
  </div>
  <div class="descriptions">
    <div class="description-tittle"><b> Turing-IA, tu mejor opción </b></div>
    <div>
      Somos una Empresa de Analítica e Inteligencia de Negocios en México con
      presencia internacional, conformada por especialistas en proyectos de
      Business Analytics. Contamos con mas de 15 años de experiencia brindando
      soluciones innovadoras en más de 10 industrias y diferentes áreas
      funcionales. Contamos con los mejores Especialistas en Análisis
      Descriptivos, Predictivos y Prescriptivos, equipados con las
      certificaciones más importantes en el desarrollo de Análisis de Datos
      mediante Knowledge Discovery in Database (KDD)
    </div>
  </div>
  <div class="img-1-us">
    <img src="https://www.turing-ia.com/assets/img/scrumn.jfif" />
    <div class="text-section-2">
      <div class="description-tittle-section-2">
        <b > Ayudamos a la toma de decisiones en todos los niveles de la empresa</b>
      </div>
      <div class="description-section2">
        Construimos e implementamos las soluciones que se ajusta a la medida de
        los retos actuales y futuros, de las organizaciones lideres en el
        mercado. Nuestro objetivo es transformar tus datos en oportunidades de
        negocio. ayudamos a la toma de decisiones en todos los niveles de la
        empresa. Con nuestras soluciones seras capaz de identificar tendencias
        de mercado, potenciar los recursos de la empresa, y crear planes de
        acción anticipando errores y amenazas para tus estrategias corporativas.
      </div>
    </div>
  </div>
  <div>
    <CardsCertifications class="cards-about"/>
  </div>
</template>

<style scoped>
.container-home {
  background-image: linear-gradient(rgba(0, 0, 0, 0.637), rgba(0, 0, 0, 0.473)),
    url("../assets/Images/pexels-fauxels-3183197.jpg");
  background-position: center;
  background-size: cover;
  display: flex;
  height: 40rem;
  overflow: hidden;
}
img {
  width: 100%;

  max-height: 120%;
  height: auto;
}
.descriptions {
  background-color: rgb(27, 21, 16);
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande",
    "Lucida Sans", Arial, sans-serif;
  font-size: 1.5rem;
  padding: 2rem;
  margin: 2rem;
  border-radius: 1%;
  color: #ffffff;
}
.description-tittle {
  padding-bottom: 3rem;
}
.img-1-us {
  display: flex;
  height: 20rem;
  width: 100%;
  margin-top: 5rem;
  margin-bottom: 5rem;
}

img {
  clip-path: polygon(
    0% 0%,
    100% 0%,
    100% 75%,
    75% 75%,
    75% 100%,
    50% 75%,
    0% 75%
  );
  transform: rotate(340deg);
  width: 30%;
  z-index: 3;
}
.text-section-2 {
  background-color: rgba(233, 234, 245, 0.733);
  width: 100%;
  margin: 2rem 2rem 2rem 0;
  z-index: 2;

}
.description-tittle-section-2{
  font-size: 1.5rem;
  padding:1rem 1rem 0 1rem;
}
.description-section2{
  background-color: rgba(255, 240, 29, 0.253);
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande",
    "Lucida Sans", Arial, sans-serif;
  font-size: 1.2rem;
  padding: 2rem;
  margin: 2rem;
  border-radius: 1%;
}
.ards-about{
  z-index: 5;
}


@media only screen and (max-width: 500px) {


 .tittle-2{
    font-size: 1rem;
    display: flex;
    padding: 1rem;
    text-align: center;
  }

  .descriptions {
  font-size: 0.9rem;
}
.img-1-us{
  height: 10rem;
  margin-bottom: 25rem;

}
.description-tittle-section-2{
  font-size: 1rem;
}

.description-section2{
  font-size: 0.7rem;
  position: sticky;
  width: 100%;
}
.container-home{
 height: 30rem;
}}
</style>
