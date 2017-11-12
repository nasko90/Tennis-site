$("#playerOne").change(function () {
    $("#playerTwo option").show();
    var playerName = this.value;
    $("#playerTwo option[value='" + playerName + "']").hide();
});

