function initShowsTab() {
    initDataTable('shows-table');
}
function updateShow(id) {

    var data = {
        IntShowID: id,
        IntBudget: $("[data-show='" + id + "_budget']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateShow', JSON.stringify(data), 'POST').done(function (response) {

        $('#shows').html(response);
        initShowsTab();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertShow() {
    var data = {
        StrName: $("[data-show='new_strName']").val(),
        StrAuthor: $("[data-show='new_strAuthor']").val(),
        IntBudget: $("[data-show='new_intBudget']").val(),
        YsnIsMusical: $("[data-show='new_ysnIsMusical']").prop('checked'),
        IntClubID: $("[data-show='new_clubID']").val(),
        IntDateID: $("[data-show='new_dateID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertShow', JSON.stringify(data), 'POST').done(function (response) {

        $('#shows').html(response);
        initShowsTab();

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

            $('#shows').html(response);
            initShowsTab();

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}