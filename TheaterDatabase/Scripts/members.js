function updateMembers(id) {

    var data = {
        IntMemberID: id
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateMembers', JSON.stringify(data), 'POST').done(function (response) {

        $('#members').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}

function insertMembers() {
    var data = {
        StrName: $("[id='new_strName']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/InsertMembers', JSON.stringify(data), 'POST').done(function (response) {

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
        AjaxCall('/Home/DeleteMembers', JSON.stringify(data), 'POST').done(function (response) {

            $('#members').html(response);

        }).fail(function (error) {
            console.log(error);
            alert(error.StatusText);
        });
    }
}