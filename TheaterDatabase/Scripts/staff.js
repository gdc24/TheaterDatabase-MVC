function updateStaff(id) {

    var data = {
        IntStaffID: id,
        IntMemberID: $("[id='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateStaff', JSON.stringify(data), 'POST').done(function (response) {

        $('#staff').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertStaff() {
    var data = {
        StrPosition: $("[id='new_strPosition']").val(),
        IntMemberID: $("[id='new_memberID']").val(),
        IntShowID: $("[id='new_showID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertStaff', JSON.stringify(data), 'POST').done(function (response) {

        $('#staff').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deleteStaff(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntStaffID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeleteStaff', JSON.stringify(data), 'POST').done(function (response) {

            $('#staff').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}