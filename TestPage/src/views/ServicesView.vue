<template>
  <div class="container-home">
    <div class="text-tittle-container">
      <div class="tittle-1">Servicios</div>
      <div class="tittle-2">
        Tenemos una gran gama de soluciones para llevar al máximo el nivel tu
        compañia
      </div>
    </div>
  </div>
  <div class="container-secction-2">
    <div>
      <img
        class="img-secction-1"
        src="https://www.turing-ia.com/blog/wp-content/uploads/2022/11/futuristic-smart-city-with-5g-global-network-technology-scaled.jpg"
        alt=""
        srcset=""
      />
    </div>
    <div class="text-1">
      <div class="tittle-section-1"><b>LO QUE OFRECEMOS</b></div>
      <div>Servicios en Turing-IA</div>
      <div>
        Proporcionamos a nuestros clientes una gama de productos y servicios
        relacionados con el analisis de datos, mediante el uso de tecnologias
        como Tableau, Salesforce, PMI, Scrum.
      </div>
    </div>
  </div>
</template>

<style scoped>
.container-home {
  background-image: linear-gradient(rgba(0, 0, 0, 0.637), rgba(0, 0, 0, 0.473)),
    url("../assets/Images/pexels-fauxels-3184291.jpg");
  background-position: center;
  background-size: cover;
  display: flex;
  height: 40rem;
  overflow: hidden;
}
.container-secction-2 {
  display: flex;
  padding: 2rem;
  width: 100%;
  flex-wrap: wrap;
}
.text-1 {
  font-size: 1.5rem;
  display: flex;
  text-align: center;
  flex-direction: column;
  padding: 2rem;
}
.tittle-section-1 {
  background-color: rgba(255, 206, 184, 0.473);
  font-size: 1.8rem;
}

.img-secction-1 {
  height: 20rem;
  width: 100%;
 
}
</style>
