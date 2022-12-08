<template>
    <div class="clients">
        <div class="text">
            <b style="padding-bottom: 2rem">LA MANERA IDEAL PARA MANEJAR TUS DATOS</b>

            Somos el socio estratégico que necesitas para potenciar los datos de tu
            organización. Contamos con más de 15 años de experiencia brindando
            soluciones innovadoras, adaptadas a las necesidades de nuestros clientes,
            en más de 10 industrias y diferentes áreas funcionales.
        </div>
        <img
            src="../assets/Images/HomeImages/pexels-azamat-esenaliev-117729.jpg"
        />
    </div>
</template>

<style scoped>
.clients {
  background: rgb(45, 21, 7);
  background: linear-gradient(
    322deg,
    rgba(45, 21, 7, 0.87718837535014) 0%,
    rgba(22, 2, 0, 0.969625350140056) 100%
  );
  height: 35rem;
  color: #ffffff;
  display: flex;
  justify-content: flex-start;
  align-items: center;
    overflow: hidden;
  font-size: x-large;
  padding: 1rem 0;
}
.text {
  display: flex;
  flex-direction: column;
  padding: 1rem;
}
img {
  height: 100%;
  clip-path: polygon(25% 0%, 100% 0%, 100% 100%, 25% 100%, 0% 50%);
}

@media only screen and (max-width: 700px){
  .clients{
    height: 20rem;
  }
  img {
  height: 50%;
  clip-path: polygon(25% 0%, 100% 0%, 100% 100%, 25% 100%, 0% 50%);
}

  .text {
  font-size: 0.8rem;
}
}

@media only screen and (max-width: 400px){
  .text {
  font-size: 0.7rem;
}
}
</style>
