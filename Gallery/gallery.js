$(document).ready(function(){
    $("#divId img").on("mouseover",function(){
        $(this).css ('border-color', 'red');
        $(this).css ('cusor', 'hand');
        console.log(this);

        });
        $("#divId img").mouseout(function(){
            $(this).css({
                "cusor" : "default",
                "border - color" : "gray"
            });
        })
        $("#divId img").click(function(){
            let mainImage = $("#mainImage");
            let imagesSRC = $(this).attr("src")
            mainImage.attr("SRC")

        })
});