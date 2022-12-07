<template>
  <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://www.turing-ia.com/assets/img/grupopetersenfallback.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://www.muycomputerpro.com/wp-content/uploads/2021/01/red-hat-stackrox.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
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



<style >
/* img{
  height: 500px;
  object-fit: scale-down;

}
  .carousel-inner{
    height: 750px;
  } */
  .d-block{
    height: 45rem;
    width: 100%;
    object-fit: unset;
  }
</style>