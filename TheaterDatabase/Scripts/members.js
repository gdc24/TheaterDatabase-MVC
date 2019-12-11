function initMembersTab() {
    initDataTable('members-table');
}

function updateMember(id) {

    var data = {
        IntMemberID: id,
        StrName: $("[data-members='" + id + "_strName']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateMember', JSON.stringify(data), 'POST').done(function (response) {

        $('#members').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertMember() {
    var data = {
        StrName: $("[data-members='new_strName']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertMember', JSON.stringify(data), 'POST').done(function (response) {

        $('#members').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}


function deleteMember(id) {
    if (confirm("Are you sure you want to delete this row? This cannot be undone")) {
        var data = {
            IntMemberID: id
        };
        console.log("data:");
        console.log(data);
        console.log(JSON.stringify(data));
        AjaxCall('/Home/DeleteMember', JSON.stringify(data), 'POST').done(function (response) {

            $('#members').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}