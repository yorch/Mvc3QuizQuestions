$(function () {
    $('.question-choices').hide();

    $('.question-title').css("cursor", "pointer").click(function () {
        $(this).next('.question-choices').slideToggle(250);
    });
});