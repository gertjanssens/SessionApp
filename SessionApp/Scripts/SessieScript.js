$(document).ready(function () {
    GetSessions();
});


function GetSessions() {
    //jQuery.support.cors = true;
    $.ajax({
        url: 'http://localhost:52449/api/Session',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function WriteResponse(sessions) {
    var strResult = "<ul>";
    $.each(sessions, function (index, session) {
        strResult += "<li><a href=InschrijfPagina.html>" + session.Name + "  " + session.Id + "<a/></li>";
    });
    strResult += "</ul>";
    $("#divResult").html(strResult);
}

$(function () {
    $('li a').on('click', function (e) {
        var htmlFile = $(this).attr('href');
        e.preventDefault();
        $('#content').load(htmlFile);
    });
});