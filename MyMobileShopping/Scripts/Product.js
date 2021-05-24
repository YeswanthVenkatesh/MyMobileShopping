var Product = {};

$(".cart-button").click(function () {
    var panel = $(this).closest(".panel");
    Product.MobileName = $(panel).find(".panel-heading > h3").text();
    Product.MobilePrice = $(panel).find(".panel-body h4").data("price");
    addToCart(Product);
});



function addToCart(product, element) {
    $.ajax({

        url: window.location.origin + "/Cart/AddToCart",
        type: "POST",
        data: JSON.stringify(product),
        contentType: "application/json",
        dataType: "html",
        success: function (data) {
            $("#popupmodal").html(data);
            $("#successmodal").modal("show");
            $(element).prop("disabled", "disabled");
        },
        error: function () {
            alert("failure")
        }
    })

}