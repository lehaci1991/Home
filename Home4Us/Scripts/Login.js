"use strict"

// $(function(){
// 	$(".button1").on("click", function(){
// 		$(".loginForm").css("left", "15%");
// 		$(".loginForm").css("right", "15%");
// 		$(".loginForm").css("bottom", "15%");
// 		$(".loginForm").css("top", "15%");

// 		$(".registerForm").css("display", "block");
// 	});
// });

$(function(){
    $(".registerLink").on("click", function () {
		document.getElementById('formId').className = "registerForm";
		document.getElementById('loginItems').style.display = "none";
		document.getElementById('registerItems').style.display = "block";
		document.getElementById('formHeader').innerHTML = "Go ahead and creat your account";
	});
});

$(function () {
    $(".contHide").on("click", function () {
        if (document.getElementById('table-manage').style.display == "none")
            document.getElementById('table-manage').style.display = "block";
        else
            document.getElementById('table-manage').style.display = "none";
    });
});