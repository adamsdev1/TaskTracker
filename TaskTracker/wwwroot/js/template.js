/*For on page load */
$(document).ready(function () {
});

/* template openModal */
function openModalOne() {
    $.ajax({
        url: '../Home/OpenMe',
        type: 'GET',
        cache: false,
        async: true,
        success: function (partialView) {
              
            alert('something')
            openModal(partialView, 'This Is A Modal', 'purple', 'medium');
        },
        error: function () {
            alert("This is an error message alert!")
        }
    });
}