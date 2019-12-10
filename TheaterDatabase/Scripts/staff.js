function initStaffTab() {
    initDataTable('staff-table');
}

function updateStaff(id) {

    var data = {
        IntStaffID: id,
        IntMemberID: $("[data-staff='" + id + "_member']").val()
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
        StrPosition: $("[data-staff='new_strPosition']").val(),
        IntMemberID: $("[data-staff='new_memberID']").val(),
        IntShowID: $("[data-staff='new_showID']").val()
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