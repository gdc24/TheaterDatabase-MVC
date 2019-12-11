function initPitsTab() {
    initDataTable('pits-table');
}


function updatePits(id) {

    var data = {
        IntPitID: id,
        IntSeat: $("[data-pits='" + id + "_intSeat']").val(),
        IntMemberID: $("[data-pits='" + id + "_member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdatePit', JSON.stringify(data), 'POST').done(function (response) {

        $('#pits').html(response);
        initPitsTab();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertPits() {
    var data = {
        StrInstrument: $("[data-pits='new_strInstrument']").val(),
        IntSeat: $("[data-pits='new_intSeat']").val(),
        IntMemberID: $("[data-pits='new_memberID']").val(),
        IntShowID: $("[data-pits='new_showID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertPit', JSON.stringify(data), 'POST').done(function (response) {

        $('#pits').html(response);
        initPitsTab();

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
        AjaxCall('/Home/DeletePit', JSON.stringify(data), 'POST').done(function (response) {

            $('#pits').html(response);
            initPitsTab();

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}