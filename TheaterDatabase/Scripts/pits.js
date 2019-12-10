function updatePits(id) {

    var data = {
        IntPitID: id,
        IntMemberID: $("[id='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdatePits', JSON.stringify(data), 'POST').done(function (response) {

        $('#pits').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertPits() {
    var data = {
        StrInstrument: $("[id='new_strInstrument']").val(),
        IntSeat: $("[id='new_intSeat']").val(),
        IntMemberID: $("[id='new_memberID']").val(),
        IntShowID: $("[id='new_showID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertPits', JSON.stringify(data), 'POST').done(function (response) {

        $('#pits').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deletePits(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntPitID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeletePits', JSON.stringify(data), 'POST').done(function (response) {

            $('#pits').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}