


function mainPage() {
    $(".results").hide();
    $(".destinationResults").hide();
    toDay();
    $("#departureTime-input").change(function () {

        departureChange();
    });
}

 

function departureChange() {
    var date = $("#departureTime-input").val().split('/');
    var mount = date[0];
    var day = date[1];
    var year = date[2];
    $("#departureTime").val(year + '-' + mount + '-' + day);
    var monthNames = ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"];
    $("#departureTime-input").val(day + ' ' + monthNames[mount - 1].toString() + ' ' + year);
    var dateNow = new Date();
    var today = dateNow.getFullYear() + '-' + (dateNow.getUTCMonth() + 1) + '-' + dateNow.getDate();
    if (today === $("#departureTime").val())
        $("#today").addClass("active");
    else {
        $("#today").removeClass("active");
        $("#tomorrow").removeClass("active");
    }

};

var _globalStartDate = new Date();

$("#departureTime-input").datepicker({
    showMonthAfterYear: true,
    monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
    dayNamesMin: ["Pa", "Pt", "Sl", "Ça", "Pe", "Cu", "Ct"],
    numberOfMonths: 1,
    format: 'dd/mm/yyyy',
    weekStart: 1,
    startDate: _globalStartDate,
    minDate: 0,
    language: "tr"
});




$("#result").click(function () {
    $(".results").show();
});
$("#destinationResult").click(function () {
    $(".destinationResults").show();
});



$(".results li").on('click', function () {

    $("#origin-input").val($(this).attr("data-value"));
    $("#origin-input-id").val($(this).attr("data-id"));
    $(".results").hide();
});


$(".destinationResults li").on('click', function () {

    $("#destination-input").val($(this).attr("data-value"));
    $("#destination-input-id").val($(this).attr("data-id"));
    $(".destinationResults").hide();
});

$("#exchange").on('click', function () {

    var destination = $("#destination-input").val();
    var destinationId = $("#destination-input-id").val();
    var origin = $("#origin-input").val();
    var originId = $("#origin-input-id").val();

    $("#origin-input").val(destination);
    $("#origin-input-id").val(destinationId);
    $("#destination-input").val(origin);
    $("#destination-input-id").val(originId);
});
$("#today").on('click', function () {

    toDay();

});


function toDay() {
    var dateNow = new Date();

    $("#departureTime-input").val(dateNow.getUTCMonth() + 1 + '/' + dateNow.getDate() + '/' + dateNow.getFullYear());
    departureChange();
    $("#tomorrow").removeClass("active");
    $("#today").addClass("active");
}

$("#tomorrow").on('click', function () {
    var dateNow = new Date();
    var tomorrow = new Date(dateNow);
    tomorrow.setDate(tomorrow.getDate() + 1);

    $("#departureTime-input").val(tomorrow.getUTCMonth() + 1 + '/' + tomorrow.getDate() + '/' + tomorrow.getFullYear());
    departureChange();
    $("#today").removeClass("active");
    $("#tomorrow").addClass("active");



});

$("#search-button").on('click', function () {
    var originCode = $("#origin-input-id").val();
    var destinationCode = $("#destination-input-id").val();
    var departureTime = $("#departureTime").val();
    var url = window.location.href.replace('#', '');
    if (originCode !== "" || destinationCode !== destinationCode)
        location.href = url + "/Home/Seferler/" + originCode + "-" + destinationCode + "/" + departureTime;
    else
        alert("Lütfen kalkış ve varış yerlerini seçiniz.")
  
});

$(".backDate").click(function () {
    var depacture = $(".dateDepacture").html();
     var date = depacture.split('.');
    var day = date[0];
    var mount = date[1];
    var year = date[2];
    var dateNow = new Date(parseInt(year), parseInt(mount), parseInt(day));
    var tomorrow = new Date(dateNow);
    tomorrow.setDate(tomorrow.getDate() - 1);
    var departureTime = tomorrow.getFullYear() + '-' + tomorrow.getMonth() + '-' + tomorrow.getDate();
    var destinationCode= $("#destinationId").val();
    var originCode = $("#originId").val();
    if (originCode !== "" || destinationCode !== destinationCode)
        location.href = "/Home/Seferler/" + originCode + "-" + destinationCode + "/" + departureTime;
 
});

$(".nextDate").click(function () {
    var depacture = $(".dateDepacture").html();
    var date = depacture.split('.');
    var day = date[0];
    var mount = date[1];
    var year = date[2];
    var dateNow = new Date(parseInt(year), parseInt(mount), parseInt(day));
    var tomorrow = new Date(dateNow);
    tomorrow.setDate(tomorrow.getDate() + 1);
    var departureTime = tomorrow.getFullYear() + '-' + tomorrow.getMonth() + '-' + tomorrow.getDate();
    var destinationCode = $("#destinationId").val();
    var originCode = $("#originId").val();
    if (originCode !== "" || destinationCode !== destinationCode)
        location.href = "/Home/Seferler/" + originCode + "-" + destinationCode + "/" + departureTime;

});
