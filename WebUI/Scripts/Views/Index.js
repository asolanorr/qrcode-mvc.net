function Index() {
    var qrcode = new QRCode("qrcode");

    this.Create = function () {
        var text = document.getElementById("text");

        qrcode.makeCode(text.value);
    }
}
