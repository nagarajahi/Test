$(document).ready(function () {

    $("#cal").on('click', function (e) {
        var weight = $("#wid").val();
        var price = $("#gid").val();
        var discount = $("#disid").val();
        if (discount == null) {
            document.getElementById('tid').value = weight * price;
        }
        else {
            document.getElementById('tid').value = (weight * price) - ((discount / 100) * (weight * price));
 
        }
    });

    $("#submitscreen").on('click', function (e) {
        $("#beforeActionConfirmationModal").modal('show');
        $("#beforeActionModalHeaderText").text("Estimate screen");
        //$("#beforeActionModalBodyText").text("Are you sure you wish to modify this user?");
        var weight = $("#wid").val();
        var price = $("#gid").val();
        var discount = $("#disid").val();
        //if (discount == null) {
        //    document.getElementById('beforeActionModalBodyText').value = weight * price;
        //}
        //else {
        //    document.getElementById('beforeActionModalBodyText').value = (weight * price) - ((discount / 100) * (weight * price));

        //}
    });

});