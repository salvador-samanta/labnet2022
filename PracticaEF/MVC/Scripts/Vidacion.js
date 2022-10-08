$(document).ready(function () {
    $("#form").validate({
        rules: {
            Nombre: {
                required: true,
                minlength: 3,
                maxlength: 15
            },
            Apellido: {
                required: true,
                minlength: 3,
                maxlength: 15
            },
            Puesto: {
                required: true,
                minlength: 3,
                maxlength: 50
            },

        },
        messages: {
            Nombre: {
                required: "Ingrese un nombre",
                minlength: "El nombre debe tener al menos 3 caracteres",
                maxlength: "El nombre no puede superar los 15 caracteres"
            },
            Apellido: {
                required: "Ingrese un Apellido",
                minlength: "El apellido debe tener al menos 3 caracteres",
                maxlength: "El apellido no puede superar los 15 caracteres"
            },
            Puesto: {
                required: "Ingrese un Puesto",
                minlength: "El puesto debe tener al menos 3 caracteres",
                maxlength: "El puesto no puede superar los 50 caracteres"
            }
        }
    });
});