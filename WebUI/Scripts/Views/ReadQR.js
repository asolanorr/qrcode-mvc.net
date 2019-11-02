let scanner = new Instascan.Scanner({
    video: document.getElementById("preview")
});
scanner.addListener('scan', function (content) {
    console.log(content);
    window.open(content, "_blank");
});
Instascan.Camera.getCameras().then(function (cameras) {
    if (cameras.length > 0) {
        scanner.start(cameras[0]);
    } else {
        alert('No cameras found.');
    }
}).catch(function (e) {
    console.error(e);
});