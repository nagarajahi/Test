$(document).ready(function () {

    $("#cancel").on('click', function (e) {
        $("#uname").val('');
        $("#pwd").val('');
    })

   //("#login").on('click', function (e) {
   //     var Name = $("#uname").val();
   //     var Password = $("#pwd").val();
   //     var AccountModel =
   //     {
   //         UserName: Name,
   //         UserPassword: Password
   //     };

   //     $ $.ajax({
   //         traditional: true,
   //         async: true,
   //         type: 'POST',
   //         //headers: { "X-CSRF-TOKEN": csrfToken },
   //         headers: { "X-CSRF-TOKEN": $("input[name='__RequestVerificationToken']").val() },
   //         url: "/Account/MyLogin",
   //         dataType: 'json',
   //         contentType: 'application/json',
   //         data: JSON.stringify(AccountModel),
   //         processData: false,
   //         success: function (data, textStatus, jQxhr) {
   //         }
   //     });

   // });
});