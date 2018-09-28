$(document).ready(function () {



    $(function () {
        $(document).on("click", ".deleteBtn", function () {
            var id = $(this).attr('comment-id');
            $.ajax({
                url: "/api/values/" + id,
                type: "DELETE",
                cache: false,
                statusCode: {
                    200: function (data) {
                        viewModel.comments.remove(
                            function (comment) {
                                return comment.Id == data.Id;
                            }
                        );
                    }
                }
            });
        });
        return false;
    })



    $("#getComments").click(function () {
        viewModel.comments([]);
        $.get('/api/values', function (data) {
            viewModel.comments(data);
        });

    });

    
});