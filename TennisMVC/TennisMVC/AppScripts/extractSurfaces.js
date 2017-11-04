$(document).ready(function () {
    $.getJSON("AddMatch/GetSurfaceTypes", {}, function (data) {
        var options = '<option value="">-- Select surface --</option>';
        for (var i = 0; i < data.length; i++) {
            options += '<option value="' + data[i] + '">' + data[i] + '</option>';
        }
        $("#surfaceDropDown").html(options);
    })
});

