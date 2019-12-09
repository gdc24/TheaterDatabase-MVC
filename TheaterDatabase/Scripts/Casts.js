

function updateCasts(id) {

    var data = {
        IntCastID: id,
        IntMemberID: $("[id='" + id + "_Member']").val()
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Admin/Showbill/UpdateClass', JSON.stringify(data), 'POST').done(function (response) {
        console.log("success");
        console.log(response);
        refresh('Class');
        confirmUpdate();

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
    var row = $("[id='" + id + "_row']");
    $("td", row).each(function () {
        $(this).find('.divYesEditing').toggle();
        $(this).find('.divNoEditing').toggle();
    });
}


