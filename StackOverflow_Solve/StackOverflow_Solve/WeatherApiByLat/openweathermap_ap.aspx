<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="openweathermap_ap.aspx.cs"
    Inherits="StackOverflow_Solve.WeatherApiByLat.openweathermap_ap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            var data;
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function(position) {
                    var lat = position.coords.latitude;
                    var lon = position.coords.longitude;
                    console.log(lat);
                    console.log(lon);
                    console.log("api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&APPID=4907e373098f091c293b36b92d8f0886");
//                    $.getJSON("api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&APPID=4907e373098f091c293b36b92d8f0886", function(json) {
//                        data = json;
//                        console.log(data.name);
//                        $("#city").text(data.name);
                    //                    });
                    var url = 'http://api.openweathermap.org/data/2.5/weather';
                    var params = {};
                    params.lat = lat;
                    params.lon = lon;
                    params.APPID = "4907e373098f091c293b36b92d8f0886";
                    
                    $.ajax({
                        type: "GET",
                        url: url,
                        dataType: "jsonp",
                        contentType: "application/json; charset=utf-8",
                        data: params,
                        success: function (res) {
                            console.log(res);
                        },
                        error: function (res) {
                        }
                    });
                    

                }
                );
            }
        });

        </script>
</head>
<body>
    <form id="form1" runat="server">

    <div>
        <div id="city">

</div>
    </div>
    </form>
</body>
</html>
