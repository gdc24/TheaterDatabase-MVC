
function initCastsTab() {
    initDataTable('casts-table');
}



function updateCasts(id) {

    var data = {
        IntCastID: id,
        IntMemberID: $("[data-cast='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateCast', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);
        initCastsTab();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertCasts() {
    var data = {
        StrVoicePart: $("[data-cast='new_strVoicePart']").val(),
        StrRole: $("[data-cast='new_strRole']").val(),
        IntMemberID: $("[data-cast='new_memberID']").val(),
        IntShowID: $("[data-cast='new_showID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertCast', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);
        initCastsTab();

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
        AjaxCall('/Home/DeleteCast', JSON.stringify(data), 'POST').done(function (response) {

            $('#casts').html(response);
            initCastsTab();

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}