<template>
  <div class="container-cards">
    <div class="card" style="width: 18rem">
      <img
        src="https://www.turing-ia.com/assets/img/pmi2%20(2).png"
        class="card-img-top"
        alt="..."
      />
      <div class="card-body">
        <p class="card-text">
          Profesionales con conocimientos y competencias acreditadas ante
          organismos nacionales (CONOCER) e internacionales (PMI® e IPMA®). -
          Aplicación e impacto inmediato en mejores prácticas para administrar
          proyectos dentro de las organizaciones. - Incremento en la capacidad
          para realizar más y mejores proyectos. - Líderes de equipos de trabajo
          altamente orientados a lograr los resultados que contribuyen a los
          objetivos estratégicos de la organización.
        </p>
      </div>
    </div>

    <div class="card" style="width: 18rem">
      <img
        src="https://www.turing-ia.com/assets/img/tableau_blueprint%20(2).png"
        class="card-img-top"
        alt="..."
      />
      <div class="card-body">
        <p class="card-text">
          Ayudamos en la toma de decisiones en todos los niveles de la empresa,
          comprender mejor los resultados de negocio, anticiparse a ellos,
          darles forma mediante la identificación de tendencias, modelos
          estadísticos, anomalías; analizarlos, comparar los casos “what-if” y
          predecir las amenazas, oportunidades potenciales, así como planificar,
          presupuestar y prever los recursos
        </p>
      </div>
    </div>

    <div class="card" style="width: 18rem">
      <img
        src="https://www.turing-ia.com/assets/img/scrum.png"
        class="card-img-top"
        alt="..."
      />
      <div class="card-body">
        <p class="card-text">
          Profesionales con conocimientos y competencias acreditadas De todas
          las formas que existen para poder desarrollar software, únicamente de
          manera colaborativa es como se logra. Es por eso que aplicamos la
          metodología Scrum para llevar más allá tus objetivos
        </p>
      </div>
    </div>

    <div class="card" style="width: 18rem">
      <img
        src="https://www.turing-ia.com/assets/img/data-driven%20(2).jpg"
        class="card-img-top"
        alt="..."
      />
      <div class="card-body">
        <p class="card-text">
          Tomamos decisiones estratégicas basadas en la interpretación y el
          análisis de datos. Es decir, se trata de ver la manera cómo se
          estructuran y organizan los datos con el fin de aplicarlos a su
          negocio y mejorar sus estrategias.
        </p>
      </div>
    </div>

    <div class="card" style="width: 18rem">
      <img
        src="https://cdn.safe.com/wp-content/uploads/2022/03/30052444/ostawarad.jpeg"
        class="card-img-top"
        alt="..."
      />
      <div class="card-body">
        <p class="card-text">
            <ul>
                <li> Big Data</li>
                <li>Data Mining</li>
                <li>Data to Insight</li>
                <li>Business Intelligence</li>
                <li>Business Analytics</li>
                <li> Machine Learning</li>
            </ul>
             
        </p>
      </div>
    </div>
  </div>
</template>

<style scoped>
.container-cards{
    display: flex;
    flex-wrap: wrap;
    justify-content: space-around;
    align-items: stretch;
    
}

.card {
    margin-bottom: 5rem;
    min-width: 30rem;
}
.card-img-top{
    height: 18rem;
    width: 100%;
    padding: 1rem;
}

@media only screen and (max-width: 500px) {
    .card {
    margin-bottom: 5rem;
    min-width: 20rem;
}
}
</style>
