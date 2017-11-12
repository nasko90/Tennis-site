$(".set").keyup(function () {
    var regex = /^\d+$/;
    var isValid = regex.test(this.value);
    if (!isValid) {
        this.style.borderColor = "red";
    }
    else {
        this.style.borderColor = "transparent";
    }

    return isValid;
});
