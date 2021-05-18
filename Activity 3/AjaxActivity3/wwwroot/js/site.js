$(function () {
    console.log("Page Loaded");

    $("#submitCustomer").click(function () {
        event.preventDefault();
        console.log("Submit was clicked");

        $.ajax({
            type: "POST",
            url: 'Customer/ShowCustomer',
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                $("#customerInfoArea").html(data);
                alert(data); 
            }
        });
    });
});