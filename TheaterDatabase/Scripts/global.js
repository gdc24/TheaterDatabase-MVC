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