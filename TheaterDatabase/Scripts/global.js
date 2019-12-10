function editRow(tableName, id) {
    var contextRow = $('#' + tableName + '-table #' + id + '_row');
    $(contextRow).find('.divNoEditing').hide();
    $(contextRow).find('.divYesEditing').show();
}

function cancelEditRow(tableName, id) {
    var contextRow = $('#' + tableName + '-table #' + id + '_row');
    $(contextRow).find('.divNoEditing').show();
    $(contextRow).find('.divYesEditing').hide();
}

function showInsertRow(tab) {
    var context = $('#' + tab);
    $(context).find('.divNoNewRow').hide();
    $(context).find('.divYesNewRow').show();
}

function hideInsertRow(tab) {
    var context = $('#' + tab);
    $(context).find('.divNoNewRow').show();
    $(context).find('.divYesNewRow').hide();
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