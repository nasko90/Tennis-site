$('#saveResult').click(function () {

    swal("Good job!", "You have successfully saved the game!", "success")
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
            return areSetsValid;
        }
    });

    return areSetsValid;
}