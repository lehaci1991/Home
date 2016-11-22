$(document).ready(function () {
        //$(".offerPreview").hide();
    $(".previewBanner").mouseenter(function () {
        if ($(this).is(":hover") && !$(this).hasClass("active")) {
            $(this).find(".offerPreview").fadeIn(500).addClass("active");
        }
    });

    $(".previewBanner").mouseleave(function () {
        $(".offerPreview").fadeOut(300).removeClass("active");
    });


    $(".col-sm-4 previewBanner").click(function () {
        $("#detailedOffer").fadeIn(500).addClass("active");
    });

    $(".col-sm-4 previewBanner").click(function () {
        $("#detailedOffer").fadeIn(500).addClass("active");

    });

    $(".offerPreview").click(function () {
        $("#detailedOffer").fadeIn(500).addClass("active");
    });

    $("#closeDetailedOffer").click(function() {
        $("#detailedOffer").fadeOut(300).removeClass("active");
    });
});

