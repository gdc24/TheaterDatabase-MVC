function updateExecs(id) {

    var data = {
        IntExecID: id,
        IntMemberID: $("[id='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateExec', JSON.stringify(data), 'POST').done(function (response) {

        $('#exec').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertExec() {
    var data = {
        StrPosition: $("[id='new_strPosition']").val(),
        IntMemberID: $("[id='new_memberID']").val(),
        IntDateID: $("[id='new_dateID']").val(),
        IntClubID: $("[id='new_clubID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertExec', JSON.stringify(data), 'POST').done(function (response) {

        $('#exec').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deleteExec(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntExecID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeleteExec', JSON.stringify(data), 'POST').done(function (response) {

            $('#exec').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}