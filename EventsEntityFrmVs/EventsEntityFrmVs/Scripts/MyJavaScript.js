$(".subscribeButton").click(
    function () {
        var eventId = $(this).attr('id');
       

        if ($(this).text() == "Subscribed") {
            $(this).text("Unsubscribed")
            
            window.location.href = '/Event/Show/' + eventId;

         }
        else
            $(this).text("Subscribed")
            
    })



//$(".interestedButton").click(
//    function () {

//        if ($(this).text() == "Interested")
//            $(this).text("Not Interested")
//        else
//            $(this).text("Interested")
//    })



$(".buttonGoTo").click(
    function () {

        window.location.href = '/Event'

    })
//var slideIndex = 0;
//carousel();

//function carousel() {
//    var i;
//    var x = document.getElementsByClassName("mySlides");
//    for (i = 0; i < x.length; i++) {
//        x[i].style.display = "none";
//    }
//    slideIndex++;
//    if (slideIndex > x.length) { slideIndex = 1 }
//    x[slideIndex - 1].style.display = "block";
//    setTimeout(carousel, 2000);
//}

$(".loginButton").click(
    function () {
        
        window.location.href = '/Account/Login'

    })

var slideIndex = 1;
showDivs(slideIndex);

function plusDivs(n) {
    showDivs(slideIndex += n);
}

function showDivs(n) {
    var i;
    var x = document.getElementsByClassName("mySlides");
    if (n > x.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = x.length };
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    x[slideIndex - 1].style.display = "block";
}

