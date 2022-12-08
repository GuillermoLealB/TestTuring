<template>
  <footer class="w-100 py-4 flex-shrink-0">
    <div class="container py-4">
      <div class="row gy-4 gx-5">
        <div class="col-lg-4 col-md-6">
          <h5 class="h1 text-white">Turing-IA</h5>
          <p class="small text-muted">
            Av. Insurgentes 601 Col. Nápoles, Benito Juárez Ciudad de México,
            México Teléfono de contacto: +52 (722) 936-96-65 Correo electrónico:
            contacto@turing-ia.com
          </p>
          <p class="small text-muted mb-0">
            &copy; Copyrights. All rights reserved.
          </p>
        </div>
        <div class="col-lg-2 col-md-6">
          <h5 class="text-white mb-3">Mapa del sitio</h5>
          <ul class="list-unstyled text-muted">
            <li><RouterLink to="/">
                    Inicio
                  </RouterLink></li>
            <li><RouterLink class="nav-link" to="/about">
                    Nosotros
                  </RouterLink></li>
            <li><RouterLink class="nav-link" to="/services">
                    Servicios
                  </RouterLink></li>
            <li><RouterLink class="nav-link" to="/tableau">
                    Tableau
                  </RouterLink></li>
          </ul>
        </div>
        <div class="col-lg-2 col-md-6">
          <h5 class="text-white mb-3">Quick links</h5>
          <ul class="list-unstyled text-muted">
            <li><a href="#">Implementación de Proyectos (Business Analyst)</a></li>
            <li><a href="#">Workshop (Blue Print)</a></li>
            <li><a href="#">Capacitación</a></li>
            <li><a href="#">Venta de Software</a></li>
            <li><a href="#">Venta de Hardware</a></li>
            <li><a href="#">Desarrollo de Aplicaciones</a></li>
          </ul>
        </div>
        <div class="col-lg-4 col-md-6">
          <h5 class="text-white mb-3">Inscríbete a nuestro newsletter</h5>
          <form action="#">
            <div class="input-group mb-3">
              <input
                class="form-control"
                type="text"
                placeholder="Recipient's username"
                aria-label="Recipient's username"
                aria-describedby="button-addon2"
              />
              <button class="btn btn-primary" id="button-addon2" type="button">
                <i class="fas ">Enviar</i>
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>
  </footer>
</template>

<style scoped>

body {
  background: #2a2e32;
}

.text-small {
  font-size: 0.9rem;
}

a {
  color: inherit;
  text-decoration: none;
  transition: all 0.3s;
}

a:hover,
a:focus {
  text-decoration: none;
  color: #ffffff;
}

.form-control {
  background: #212529;
  border-color: #545454;
  color: #ffffff;
}

.form-control:focus {
  background: #212529;
}

footer {
  background: #212529;
}

/* ==========================================
    CUSTOM UTILS CLASSES
  ========================================== */
body,
html {
  height: 100%;
}
</style>
