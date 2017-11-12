$(document).ready(function extractPlayers () {
    $.getJSON("AddMatch/GetPlayersNames", {}, function (data) {
        var options = '<option value="">-- Select player --</option>';
        for (var i = 0; i < data.length; i++) {
            options += '<option value="' + data[i] + '">' + data[i] + '</option>';
        }
        $(".extractPlayersNamesDropDown").html(options);
    })
});