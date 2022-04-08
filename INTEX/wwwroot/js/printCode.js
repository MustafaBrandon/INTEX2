new QRCode(document.getElementById("qrCode"),
    {
        text: "@Html.Raw(Model.AuthenticatorUri)",
        width: 175,
        height: 175
    });