$(document).ready(function () {
    var _isMenuOpen = false;
    $("#welcomeUser").addClass("dropImage"); //Only shows drop down trigger when js is enabled (Adds empty span tag after ul.subnav*)  

    $("#welcomeUser").click(function () { //When trigger is clicked...  
        //Following events are applied to the subnav itself (moving subnav up and down)  
        $("ul.subnav").slideDown('fast').show(); //Drop down the subnav on click  

        $(this).parent().hover(function () {
        }, function () {
            _isMenuOpen = false; //When the mouse hovers out of the subnav, move it back up  
        });

        //Following events are applied to the trigger (Hover events for the trigger)  
    }).hover(function () {
        _isMenuOpen = true;
        //On hover over, add class "subhover"  
    }, function () {  //On Hover Out 
        _isMenuOpen = false;
        //On hover out, remove class "subhover"  
    });
    $("body").mouseup(function () {
        if (!_isMenuOpen) { $("ul.subnav").slideUp(500); $(this).addClass("subhover"); } else $(this).removeClass("subhover");
        //if (!_isMenuOpen) { $(this).parent().find("ul.subnav").slideUp(500); $(this).addClass("subhover"); } else $(this).removeClass("subhover");
    });
});