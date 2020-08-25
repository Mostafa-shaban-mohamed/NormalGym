$(document).ready(function () {

    //Default view
    $("#myContentView").load('/Home/_Home');

    $('#HomeBtn').on('click', function () {
        $("#myContentView").load('/Home/_Home');
    });

    $('#SchBtn').on('click', function () {
        $("#myContentView").load('/Home/Schedule');
    });

    $('#AboutBtn').on('click', function() {
        $("#myContentView").load('/Home/About');
    });
    
    $('#ContactBtn').on('click', function() {
        $("#myContentView").load('/Home/Contact');
    });

});