const formulario = document.getElementById('formulario');
const inputs= document.querySelectorAll('#formulario input');

const expresiones = {
	nombre: /^[a-zA-ZÀ-ÿ\s]{1,40}$/,
    apellido: /^[a-zA-ZÀ-ÿ\s]{1,40}$/,
	edad: /^[0-9]{1,3}$/,
    correo: /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/,
    empresa: /^[a-zA-Z0-9_.+-]$/,
}


const campos = {
	nombre: false,
	apellido: false,
	correo: false,
    edad: false
}

const validarFormulario = (e) => {

    switch (e.target.name){
        case "nombre":
            validarCampo(expresiones.apellido, e.target, 'Nombre');
        break;
        case "apellido":
            validarCampo(expresiones.apellido, e.target, 'Apellido');
        break;
        case "edad":
            validarCampo(expresiones.edad, e.target, 'Edad');
        break;
        case "correo":
            validarCampo(expresiones.correo, e.target, 'Correo');
        break;
        case "empresa":
            validarCampo(expresiones.empresa, e.target, 'Correo');
        break;
    }
}

const validarCampo = (expresion, input, campo) => {
    if(expresion.test(input.value)){
        document.getElementById(`grupo${campo}`).classList.remove('formularioGrupo-incorrecto')
        document.getElementById(`grupo${campo}`).classList.add('formularioGrupo-correcto')
        // document.querySelector(`#grupo${campo}.formularioInputError`).classList.add('formularioInputError')
        campos[campo] = true;
        
    }
    else {
        document.getElementById(`grupo${campo}`).classList.add('formularioGrupo-incorrecto')
        document.querySelector(`#grupo${campo} .formularioInputError`).classList.remove('formularioInputError')
        campos[campo] = false;
    }
}

inputs.forEach((input) => {
    input.addEventListener('keyup', validarFormulario);
    input.addEventListener('blur', validarFormulario);
});

