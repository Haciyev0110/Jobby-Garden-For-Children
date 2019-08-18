$(document).on("click", ".comlistt", function (a) {
    var postId = $(this).data("postid");
    var description = $("#text").val();
    debugger
    if (description != undefined && description != null && description != "") {
        $("#errorMsg").css("display", "none")
        

        $.ajax({
            type: "Post",
            url: "/Ajax/CommentLis",
            dataType: "html",
            data: { description: description, postId: postId },
            success: function (res) {
                debugger
                if (res ==0) {
                    document.location.href = "/accountuser/accountindex";
                }
                if (res != "fail") {

                    $(".comabout").append(res);

                    $("#text").val("")
                    
                }

               
            }    
          
        })
      
    }
    
    else {
        $("#errorMsg").css("display","block")
    }
    
})
