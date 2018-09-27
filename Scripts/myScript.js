$(function () {
    $("#getComments").click(function () {
        viewModel.comments([]);
        $.get('/api/values', function (data) {
            viewModel.comments(data);
        });

    });
});