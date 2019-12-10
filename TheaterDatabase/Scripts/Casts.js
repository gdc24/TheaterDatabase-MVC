

function updateCasts(id) {

    var data = {
        IntCastID: id,
        IntMemberID: $("[id='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateCasts', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertCasts() {
    var data = {
        StrVoicePart: $("[id='new_strVoicePart']").val(),
        StrRole: $("[id='new_strRole']").val(),
        IntMemberID: $("[id='new_memberID']").val(),
        IntShowID: $("[id='new_showID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertCasts', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deleteCasts(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntCastID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeleteCasts', JSON.stringify(data), 'POST').done(function (response) {

            $('#casts').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}