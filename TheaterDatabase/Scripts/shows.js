

//function updateShow(id) {

//    var data = {
//        IntShowID: id,
//        StrName: $("[id='" + id + "_StrName']").val(),
//        StrAuthor: $("[id='" + id + "_StrAuthor']").val(),
//        IntBudget: $("[id='" + id + "_IntBudget']").val(),
//        YsnIsMusical: $("[id='" + id + "_YsnIsMusical']").prop('checked')
//    };
//    console.log("data:");
//    console.log(data);
//    console.log(JSON.stringify(data));
//    AjaxCall('/Admin/Showbill/UpdateClass', JSON.stringify(data), 'POST').done(function (response) {
//        console.log("success");
//        console.log(response);
//        refresh('Class');
//        confirmUpdate();

//    }).fail(function (error) {
//        console.log(error);
//        alert(error.StatusText);
//    });
//    var row = $("[id='" + id + "_row']");
//    $("td", row).each(function () {
//        $(this).find('.divYesEditing').toggle();
//        $(this).find('.divNoEditing').toggle();
//    });
//}


function loadPartialView(str, action) {
    var id = str.substring(0, str.indexOf(":"));
    var obj = { intClassNumber: id };
    AjaxCall('/Home/' + action, JSON.stringify(obj), 'POST').done(function (response) {
        $('#viewToLoad').html(response);
    });
}

function AjaxCall(url, data, type) {
    return $.ajax({
        url: url,
        type: type ? type : 'GET',
        data: data,
        contentType: 'application/json',
        async: false
    });
}