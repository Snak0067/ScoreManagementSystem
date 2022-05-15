//鍒锋柊浜岀淮鐮�
$("#qr_refresh").bind("click", function () {
    refresh();
});
$("#qr_refresh_span").bind("click", function () {
    refresh();
});

function refresh() {
    getQrCode($("#uuid").val());
    window.location.reload();
}

function getQrCode(uuid) {
    $.ajax({
        url: contextPath + "/qrCode/get?ts=" + new Date().getTime(),
        data: {"uuid": uuid},
        dataType: "text",
        success: function (data, textStatus) {
            if (textStatus == "success" && data != "") { // 璇锋眰鎴愬姛
                var src = contextPath + "/qrCode/code?uuid=" + data;
                $("#qr_img").attr("src", src);
                $("#invalid_img").attr("src", src);
                $("#uuid").val(data)
            }
        }
    });
}

var qr_time;
function countDown() {
    qr_time = setTimeout(function () {
        isUsed();
        countDown();
    }, 1000);
}

//浜岀淮鐮佺姸鎬�
function isUsed() {
    $.ajax({
        url: contextPath + "/qrCode/status?ts=" + new Date().getTime(),
        data: {"uuid": $("#uuid").val()},
        dataType: "text",
        timeout: 5000,
        error: function () {
            clearTimeout(qr_time);
        },
        success: function (data, textStatus) {
            if (textStatus == "success" && data == "1") { // 璇锋眰鎴愬姛
                clearTimeout(qr_time);
                $("#qrLoginForm").submit();
            }
            if (textStatus == "success" && data == "2") { // 浜岀淮鐮佸凡琚壂鎻忚烦
                $("#qr_code").hide();
                $("#qr_invalid").hide();
                $("#qr_success").show();
            }
            if (textStatus == "success" && data == "3") { // 浜岀淮鐮佸凡澶辨晥椤甸潰
                clearTimeout(qr_time);
                $("#qr_code").hide();
                $("#qr_success").hide();
                $("#qr_invalid").show();
            }
        }
    });
}
