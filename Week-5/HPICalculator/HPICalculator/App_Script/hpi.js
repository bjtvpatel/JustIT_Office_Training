//var btnclick = document.getElementById("Button_checkhouseprice");
//btnclick.addEventListener("click", loadJsondata(), true);

//function loadJsondata() {

//    var objrequest = XMLHttpRequest();
//    if (objrequest) {

//        objrequest.open('GET', "https://github.com/dariusk/corpora/blob/master/data/animals/birds_antarctica.json", true);
//        //objrequest.withCredentials = true;
//        objrequest.setRequestHeader()
//        objrequest.onreadystatechange = function () {
//            if (this.readyState == 4 & this.status == 200) {
//                var requestedData = JSON.parse(objrequest.responseText);
//            }
//            console.log("Not Ready");

//        }
//        objrequest.send();
//    }
//};

////chart script
//window.onload = function () {
//    var chart = new CanvasJS.Chart("chartContainer",
//    {

//        axisX: {
//            valueFormatString: "MM-YYYY",
//            interval: 1,
//            intervalType: "year"
//        },
//        axisY: {
//            includeZero: false

//        },
//        data: [{
//            type: "line",

//            dataPoints: [
//                        { x: new Date(2012, 00, 1), y: 450 },
//                        { x: new Date(2012, 01, 1), y: 414 },
//                        { x: new Date(2012, 02, 1), y: 520, indexLabel: "highest", markerColor: "red", markerType: "triangle" },
//                        { x: new Date(2012, 03, 1), y: 460 },
//                        { x: new Date(2012, 04, 1), y: 450 },
//                        { x: new Date(2012, 05, 1), y: 500 },
//                        { x: new Date(2012, 06, 1), y: 480 },
//                        { x: new Date(2012, 07, 1), y: 480 },
//                        { x: new Date(2012, 08, 1), y: 410, indexLabel: "lowest", markerColor: "DarkSlateGrey", markerType: "cross" },
//                        { x: new Date(2012, 09, 1), y: 500 },
//                        { x: new Date(2012, 10, 1), y: 480 },
//                        { x: new Date(2012, 11, 1), y: 510 }
//            ]
//        }
//        ]
//    });

//    chart.render();
//}

//ajax script 
//        $.ajax({
//            type: "GET",
//            url: "/Data/Test.json",
//            //beforeSend: function () {

//            //    $.blockUI({
//            //        fadeIn: 0,
//            //        fadeOut: 0,
//            //        showOverlay: false

//            //    });
//            //},
//            datatype: JSON,

//            done: function (data) {
//                console.log(data);
//                $("#JSONdata").html(data);
//            },
//           fail: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
//            },
//            //complete: function () {
//            //    $.unblockUI();
//        });
//    });
//});
