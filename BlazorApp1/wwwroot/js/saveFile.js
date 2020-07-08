﻿function saveFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:appllication/octet-stream;base64, " + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
