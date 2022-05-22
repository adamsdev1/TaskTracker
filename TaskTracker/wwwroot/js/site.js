// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*For on page load */
$(document).ready(function () {
});

/* template openModal */
function openModalOne() {
    $.ajax({
        url: '../Home/OpenMe/',
        type: "GET",
        cache: false,
        async: true,
        success: function (partialView) {
            alert("Yes");
            //openModal(partialView, "This is A Modal", "primary", "large");
        },
        error: function () {
            alert("This is an error message alert!")
        }
    })
}