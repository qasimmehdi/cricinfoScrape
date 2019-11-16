$(document).ready(function($) {
    $(".click-row").click(function() {
        window.location = $(this).data("href");
    });
});

$('#select-players tbody').on('click','tr', function (e) {
    $(this).find('i:first').removeClass('fa-plus-square');
    $(this).find('i:first').addClass('fa-minus-square');
    var row = $(this).closest('tr').html();
    $('#my-team tbody').append('<tr>'+row+'</tr>');
    $(this).closest('tr').remove();
});

$('#my-team tbody').on('click', 'tr', function (e) {
    $(this).find('i:first').removeClass('fa-minus-square');
    $(this).find('i:first').addClass('fa-plus-square');
    var row = $(this).closest('tr').html();
    $('#select-players tbody').append('<tr>'+row+'</tr>');
    $(this).closest('tr').remove();
});
