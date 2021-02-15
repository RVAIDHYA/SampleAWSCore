$(document).ready(function () {

    $(document).ready(function () {
        $("ul[id*=lstmenu] li a").click(function () {

            $("ul[id*=lstmenu] li ").children().removeClass('active');
            $(this).addClass("active");

            if ($(this).attr("id") == "menuAbout") {

                $('html, body').animate({ scrollTop: $('#divAbout').offset().top }, 'slow');
            }
            if ($(this).attr("id") == "menuProfessionalSummary") {

                $('html, body').animate({ scrollTop: $('#divSummary').offset().top }, 'slow');
            }
            if ($(this).attr("id") == "menuTechnology") {

                $('html, body').animate({ scrollTop: $('#divTechnology').offset().top }, 'slow');
                
            }
            if ($(this).attr("id") == "menuCareer") {

                $('html, body').animate({ scrollTop: $('#divCareer').offset().top }, 'slow');
            }
            if ($(this).attr("id") == "menuEducation") {

                $('html, body').animate({ scrollTop: $('#divEducation').offset().top }, 'slow');
            }

        });
    });
});