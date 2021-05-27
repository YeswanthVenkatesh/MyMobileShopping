$('input[type=radio][name=billing-Options').change(function () {
    if ((this.value == 'card')) {
        if ($('#checkOut').hasClass('disabled')) {
            $('#checkOut').removeClass('disabled');
        }
    }
    else {
        if (!($('#checkOut').hasClass('disabled'))) {
            $('#checkOut').addClass('disabled');
        }
    }

});

$('#checkOut').on('click', function () {

    window.location.href = window.location.origin + "/Payment/Index?grandTotal="+ grandTotal;

});

$('#makePayment').on('click', function () {
    var cardNumber = $('#card-number').val();
    var cvvNumber = $('#cvv').val();
    var expiryDate = $('#expiry-date').val();
    var creditCardDetails =
    {
        CardNumber: cardNumber,
        CVVNumber: cvvNumber,
        ExpiryDate: expiryDate
    };
    $.ajax({
        url: window.location.origin + "/Payment/Pay",
        type: "POST",
        data: JSON.stringify(creditCardDetails),
        contentType: "application/json",
        dataType: "html",
        success: function (data) {
            $("#billing-status-msg").html(data);

        },
        error: function () {
            alert("failure");
        }

    });

});