$(document).ready(function () {
    var Expchart = new Highcharts.Chart({
        chart: {
            renderTo: 'MonthlyStatistic',
            defaultSeriesType: 'area'
        },
        credits: {
            enabled: false
        },
        legend: {
            enabled: false
        },
        title: {
            text: 'Month wise Statistics'
        },
        xAxis: {
            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'July', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        },
        yAxis: {
            title: {
                text: 'Issues Fixed'
            }
        },
        plotOptions: {
            area: {
                marker: {
                    enabled: false,
                    symbol: 'circle',
                    radius: 2,
                    states: {
                        hover: {
                            enabled: true
                        }
                    }
                }
            }
        },
        series: [{
            name: 'Issues fixed',
            data: [30,20,50,60,53,50,42,30,28,53,45,40]
        }]
    });

    var topChart = new Highcharts.Chart({
        chart: {
            renderTo: 'topChart',
            defaultSeriesType: 'line'
        },
        credits: {
            enabled: false
        },
        legend: {
            enabled: false
        },
        title: {
            text: 'Weekly Statistics'
        },
        xAxis: {
            categories: ['Sun', 'Mon', 'Tue', 'Wed', 'Thru', 'Fri', 'Sat']
        },
        yAxis: {
            title: {
                text: 'Issues Fixed'
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    enabled: true
                },
                enableMouseTracking: false
            }
        },
        series: [{
            name: 'Issues fixed',
            data: [30, 20, 50, 60, 53, 50, 42]
        }]
    });

    var bottomchart = new Highcharts.Chart({
        chart: {
            renderTo: 'bottomChart',
            defaultSeriesType: 'pie'
        },
        credits: {
            enabled: false
        },
        legend: {
            enabled: false
        },
        title: {
            text: 'Tenant Statistics'
        },
        xAxis: {
            categories: ['Blackboard', 'Aspect', 'Viewpoints', 'IBM']
        },
        yAxis: {
            title: {
                text: 'Issues Fixed'
            }
        },
        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                dataLabels: {
                    enabled: false,
                    style: {
                        color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                    }
                }
            }
        },
        series: [{
            name: 'Issues fixed',
            data: [30, 20, 50, 60]
        }]
    });
   
});