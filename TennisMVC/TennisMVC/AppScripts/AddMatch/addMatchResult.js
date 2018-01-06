function AddMatch() {

    var playerOne = {
        "Name": $("#playerOne").val(),
        "SetsResult": [$("#playerOneSetOne").val(), $("#playerOneSetTwo").val(), $("#playerOneSetThree").val()]
    }

    var playerTwo = {
        "Name": $("#playerTwo").val(),
        "SetsResult": [$("#playerTwoSetOne").val(), $("#playerTwoSetTwo").val(), $("#playerTwoSetThree").val()]
    }

    var gameInfo =
        {
            "surface": $("#surfaceDropDown").val(),
            "date": "2017/05/05",
            "Players": [playerOne, playerTwo]
        }; 

    var myJSON = JSON.stringify(gameInfo); 

    $.ajax({
        url: '/AddMatch/SaveResult',
        type: 'POST',
        dataType: 'json',
        data: myJSON,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            // get the result and do some magic with it
            var message = data.Message;
            $("#resultMessage").html(message);
        }
    });
}