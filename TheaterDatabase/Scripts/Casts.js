
function initCastsTab() {
    initDataTable('casts-table');
}



function updateCasts(id) {

    var data = {
        IntCastID: id,
        IntMemberID: $("[data-cast='cast_" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateCasts', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);
        initCastsTab();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertCasts() {
    var data = {
        StrVoicePart: $("[data-cast='cast_new_strVoicePart']").val(),
        StrRole: $("[data-cast='cast_new_strRole']").val(),
        IntMemberID: $("[data-cast='cast_new_memberID']").val(),
        IntShowID: $("[data-cast='cast_new_showID']").val()
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