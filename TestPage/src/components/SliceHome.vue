<template>
  <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <div class="text-img"><b>Grupo Petersen crea una cultura de datos con Tableau</b></div>
      <img src="https://www.turing-ia.com/assets/img/grupopetersenfallback.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <div class="text-img"><b>Red Hat adopta el Blueprint de Tableau y Tableau Online, y profundiza en la cultura de datos con más de 4500 empleados en menos de un año</b></div>
      <img src="https://www.muycomputerpro.com/wp-content/uploads/2021/01/red-hat-stackrox.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <div class="text-img"><b>Verizon usa Tableau para reducir las llamadas de soporte en un 43 % y así mejorar la experiencia del cliente</b></div>
      <img src="https://commercialobserver.com/wp-content/uploads/sites/3/2014/05/intergatemanattan-window-wall-project-e1437079961237.jpg?quality=80&w=768" class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
</template>



<style scoped>

  .d-block{
    height: 45rem;
    width: 100%;
    object-fit: unset;
    position: relative;
    color:transparent;
  }
  .text-img{
    position: absolute;
    z-index: 5;
  }

  .carousel-item{
    color: transparent;
    font-size: 500%;
    text-align: center;
    align-items: center;
  }
  .carousel-item, img{
    transition:all .5s ease-in-out;
  }
  
  img:hover{
    filter: brightness(0.30);
  }
  .carousel-item:hover{
    
    color: #ffffff;
  }

  @media only screen and (max-width: 400px){
    .d-block{
    height: 25rem;
    width: 100%;

  }
  .carousel-item{
    color: #ffffff;
    font-size: 100%;



  }
  img{
    filter: brightness(0.30);
  }
 
  }
</style>