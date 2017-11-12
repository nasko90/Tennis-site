$("#surfaceDropDown").change(function () {
     switch (this.value) {
        case "Grass":
            document.getElementById("backGroundPicture").style.backgroundImage = "url('../Images/grass.jpg')";
            break;
        case "Clay":
            document.getElementById("backGroundPicture").style.backgroundImage = "url('../Images/clay.jpg')";
            break;
        case "Indoor":
            document.getElementById("backGroundPicture").style.backgroundImage = "url('../Images/indoor.jpg')";
            break;
        case "Hard":
            document.getElementById("backGroundPicture").style.backgroundImage = "url('../Images/hard.jpg')";
            break;
        default:
            document.getElementById("backGroundPicture").style.backgroundImage = "url('../Images/images.jpg')";
            break;
    } 
});