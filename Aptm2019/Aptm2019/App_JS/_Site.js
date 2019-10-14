function showLoading(mensaje) {
    $("#loadingModal").css({ 'display': 'block' });
    $("#loadingModal").find('#loadingMessage').html(mensaje || 'Cargando servicios...');

}
function hideLoading() {
    $("#loadingModal").css({ 'display': 'none' });
    $("#loadingModal").find('#loadingMessage').html('');
}

$(document).ready(function () {
    $('#dismiss, .overlay').on('click', function () {
        // hide sidebar
        $('#sidebar').removeClass('active');
        // hide overlay
        $('.overlay').removeClass('active');
    });

    $('#sidebarCollapse').hover(function () {
        // open sidebar
        $('#sidebar').addClass('active');
        // fade in the overlay
        $('.overlay').addClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    }, null);
});