console.log(document.getElementById("qrString").value)

new QRCode(document.getElementById("qrCode"),
    {
        text: document.getElementById("qrString").value,
        width: 175,
        height: 175
    });