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

    <div>Turing-IA, tu mejor opción </div>
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
    <img src="https://www.turing-ia.com/assets/img/scrumn.jfif" alt="" srcset="">
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
  border-radius: 2%;
  color: #ffffff;
}
.img-1-us{
  margin: 2rem;
  clip-path: polygon(0% 0%, 100% 0%, 100% 75%, 75% 75%, 75% 100%, 50% 75%, 0% 75%);
}
</style>
