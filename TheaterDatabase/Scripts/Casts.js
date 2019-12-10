

function updateCasts(id) {

    var data = {
        IntCastID: id,
        StrVoicePart: $("[id='" + id + "_voicePart']"),
        StrRole: $("[id='" + id + "_role']"),
        IntMemberID: $("[id='" + id + "_intMemberID']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/UpdateCasts', JSON.stringify(data), 'POST').done(function (response) {

        $('#casts').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}