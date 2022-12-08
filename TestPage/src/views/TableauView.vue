
<template>
  <div class="container-home">
    <div class="text-tittle-container">
      <div class="tittle-1">Tableau</div>
      <div class="tittle-2">
        Ayuda a las personas a ver y comprender los datos
      </div>
    </div>
  </div>
  <div class="descriptions">
    <h1></h1>
    Lorem ipsum dolor sit amet consectetur adipisicing elit. Temporibus modi nam
    vitae ducimus ipsam assumenda iure aliquid itaque rem excepturi culpa soluta
    odio suscipit neque dolorem, quasi facilis hic maxime.
  </div>
  <div v-if="enviado" class="container-form-tableu">
    <div class="tittle-tableu"><b> Te interesa? Dejanos tu solicitud</b></div>
    <div class="Form-Tableu">
        <div>
      <label for="exampleFormControlInput1" class="form-label">E-mail</label>
      <input
        v-model="email"
        type="email"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="name@example.com"
      />
    </div>
    <div>
      <label for="exampleFormControlInput1" class="form-label">Empresa</label>
      <input
      v-model="empresa"
        class="form-control"
        type="text"
        placeholder="Default input"
        aria-label="default input example"
      />
    </div>
    <div>
      <label for="exampleFormControlInput1" class="form-label">Telefono</label>
      <input
        v-model="telefono"
        class="form-control"
        type="number"
        placeholder="Numero de telefono"
        aria-label="default input example"
      />
    </div>
    <div>
      <label for="exampleFormControlInput1" class="form-label"
        >Selecciona una Opción:</label
      >
      <select v-model="selected" class="form-select" aria-label="Default select example">
        <option selected>Tableau Products</option>
        <option value="PREP">TABLEAU PREP</option>
        <option value="DESKTOP">TABLEAU DESKTOP</option>
        <option value="CLOUD">TABLEAU CLOUD</option>
        <option value="SERVER">TABLEAU SERVER</option>
        <option value="DATA">TABLEAU DATA MANAGEMENT</option>
        <option value="VARIOS">VARIOS TABLEAU</option>
      </select>
      </div>
      <div class="button-form-tableu">
        <button @click="handleClick" class="btn btn-bd">Enviar</button>
      </div>
    </div>
  </div>
  <div v-else="enviado" class="container-send">
    Correctamente Enviado
  </div>
</template>

<script setup>
import { ref } from "vue";
import RegisterProductVue from "../components/RegisterProduct.vue";
var email,empresa,telefono,selected;
const enviado=ref(true);
const handleClick =() => {
    let customer={
  "email": email,
  "company": empresa,
  "phone": telefono.toString(),
  "type": selected
    }
    fetch('http://localhost:5240/api/Customer/Save', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(customer),
      }).then(Enviado())

}
const Enviado=()=>{
    enviado.value=false
}
</script>



<style scoped>

.container-form-tableu{
    border-radius: 20px;
    border: 2px solid rgb(184, 184, 184);
    padding: 2rem ;
    margin: 5rem auto;
    background-color: rgba(46, 28, 2, 0.87);
    color: #ffffff;
    max-width: 90rem;

}

.Form-Tableu{
    padding: 1rem 5rem;
}

.btn-bd {
  --bs-btn-font-weight: 600;
  --bs-btn-color: var(--bs-white);
  border:2px solid #ffffff ;
}

.button-form-tableu{
    margin: 1rem;
    display: flex;
    justify-content: center;
}
.container-home {
  background-image: linear-gradient(rgba(0, 0, 0, 0.637), rgba(0, 0, 0, 0.473)),
    url("../assets/Images/pexels-fauxels-3183156.jpg");
  background-position: center;
  background-size: cover;
  display: flex;
  height: 40rem;
  overflow: hidden;
}

.container-send{
    background-color: rgba(46, 28, 2, 0.87);
    height: 10rem;
    color: #ffffff;
    text-align: center;
    font-size: 2rem;
    padding: 2rem;
}
</style>
