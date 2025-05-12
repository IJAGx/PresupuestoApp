// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function mostrarModal() {
    document.getElementById("modalConfirmacion").style.display = "flex";
}

function cerrarModal() {
    document.getElementById("modalConfirmacion").style.display = "none";
}

function confirmarRedireccion() {
    window.location.href = "/Presupuesto/Index";
}
// Write your JavaScript code.
