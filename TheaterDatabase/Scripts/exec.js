
function initExecTab() {
    initDataTable('exec-table');
}

function updateExecs(id) {

    var data = {
        IntExecID: id,
        IntMemberID: $("[data-exec='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateExec', JSON.stringify(data), 'POST').done(function (response) {

        $('#exec').html(response);
        initExecTab();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertExec() {
    var data = {
        StrPosition: $("[data-exec='new_strPosition']").val(),
        IntMemberID: $("[data-exec='new_memberID']").val(),
        IntDateID: $("[data-exec='new_dateID']").val(),
        IntClubID: $("[data-exec='new_clubID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertExec', JSON.stringify(data), 'POST').done(function (response) {

        $('#exec').html(response);
        initExecTab();

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
            initExecTab();

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}