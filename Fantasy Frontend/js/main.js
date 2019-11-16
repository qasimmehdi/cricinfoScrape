$(document).ready(function($) {
    $(".click-row").click(function() {
        window.location = $(this).data("href");
    });
});

$('#select-players tbody tr td span i').on('click', function (e) {
    $(this).closest('i').removeClass('fa-plus-square');
    $(this).closest('i').addClass('fa-minus-square');
    var row = $(this).closest('tr').html();
    $('#my-team tbody').append('<tr>'+row+'</tr>');
    $(this).closest('tr').remove();
});


$('#my-team tbody tr td span i').on('click', function (e) {
    $(this).closest('i').removeClass('fa-minus-square');
    $(this).closest('i').addClass('fa-plus-square');
    var row = $(this).closest('tr').html();
    $('#select-players tbody').append('<tr>'+row+'</tr>');
    $(this).closest('tr').remove();
});

