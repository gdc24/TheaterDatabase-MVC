function initShowsTab() {
    initDataTable('shows-table');
}
function updateShow(id) {

    var data = {
        IntShowID: id,
        IntClubID: $("[id='" + id + "_club']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateShow', JSON.stringify(data), 'POST').done(function (response) {

        $('#show').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertShow() {
    var data = {
        StrName: $("[id='new_strName']").val(),
        StrAuthor: $("[id='new_strAuthor']").val(),
        IntBudget: $("[id='new_intBudget']").val(),
        YsnIsMusical: $("[id='new_ysnIsMusical']").val(),
        IntClubID: $("[id='new_clubID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertShow', JSON.stringify(data), 'POST').done(function (response) {

        $('#show').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deleteShow(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntShowID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeleteShow', JSON.stringify(data), 'POST').done(function (response) {

            $('#show').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}