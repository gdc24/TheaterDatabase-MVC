

function makeBudgetAvgGraph() {
    budgetLst = JSON.parse($('#budgetAvgHidden').val());

    var labels = budgetLst.map(function (e) {
        return e.StrClubName;
    });
    var data = budgetLst.map(function (e) {
        return e.IntBudgetAverage;
    });;

    dataset = {
        labels: labels,
        datasets: [
            {
                label: 'CWRU Clubs',
                data: data
            }
        ]
    }

    makeChartJS('budget-avg-chart', 'bar', dataset, 'Avg Budgets', 'brewer.PiYG3');
}


function makeMusicalCountsGraph() {
    musicalCountsLst = JSON.parse($('#musicalCountsHidden').val());

    var labels = musicalCountsLst.map(function (e) {
        return e.StrShowType;
    });
    var data = musicalCountsLst.map(function (e) {
        return e.IntCount;
    });;

    dataset = {
        labels: labels,
        datasets: [
            {
                label: 'CWRU Clubs',
                data: data
            }
        ]
    }

    makeChartJS('musical-counts-chart', 'pie', dataset, 'Type of Show', 'brewer.GnBu3');
}


function updateRepeatStaffsTable() {
    var strPositionFromDropdown = $('#StrPosition').val();
    var data = {
        strPosition: strPositionFromDropdown,
    };
    console.log("data:");
    console.log(data);
    console.log(JSON.stringify(data));
    AjaxCall('/Home/GetRepeatStaff', JSON.stringify(data), 'POST').done(function (response) {

        $('#repeat-staffs').html(response);

    }).fail(function (error) {
        console.log(error);
        alert(error.StatusText);
    });
}