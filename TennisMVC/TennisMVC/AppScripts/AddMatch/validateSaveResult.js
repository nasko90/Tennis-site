$('#saveResult').click(function () {

    var isValid = validateSets() && validatePlayers() && validateSurface();
    
    if (isValid) {
        var result = AddMatch();

        if (result) {
            swal("Good job!", "You have successfully saved the game!", "success");

        }
    }
});

function validateSets() {

    var regex = /^\d+$/,
        areSetsValid = true,
        sets = $(".set");

    sets.each(function () {

        if (this.value === "") {
            return true;
        }

        areSetsValid = regex.test(this.value);
        if (!areSetsValid) {
            swal("Sorry!", "Invalid set result.", "error");
            return areSetsValid;
        }
    });

    return areSetsValid;
}

function validatePlayers() {

    var players = $(".extractPlayersNamesDropDown");

    players.each(function () {
        if (this.value === "") {
            swal("Sorry!", "Please select both players.", "error");
            return false;
        }
    });

    return true;
}

function validateSurface() {

    var surface = $("#surfaceDropDown");


    if (surface === "") {
        swal("Sorry!", "Please select surface.", "error");
        return false;
    }

    return true;
}