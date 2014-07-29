$(document).ready(function () {
    $('#issueTable').dataTable({ "bAutoWidth": false, "bPaginate": true, "bJQueryUI": false, "sPaginationType": "full_numbers", "oLanguage": { "sSearch": "Search:" }, "iDisplayLength": 10, "aaSorting": [[1, "asc"]] });
    $('#logissue').bind('click', function () {
        $("#cmp_AddIssue_ModalWindow").modal({
            zIndex: 777, opacity: 50, overlayCss: { backgroundColor: "#000000" }, onOpen: function (dialog) {
                dialog.overlay.fadeIn('fast', function () {
                    dialog.container.slideDown('slow', function () {
                        dialog.data.fadeIn('slow');
                    });
                });
            }, onClose: function (dialog) {
                dialog.data.fadeOut('slow', function () {
                    dialog.container.slideUp('slow', function () {
                        dialog.overlay.fadeOut('slow', function () {
                            $.modal.close(); // must call this!
                        });
                    });
                });
            }
        });
    });

    $('#assignTo').bind('click', function () {
        $("#cmp_AssignIssue_ModalWindow").modal({
            zIndex: 777, opacity: 50, overlayCss: { backgroundColor: "#000000" }, onOpen: function (dialog) {
                dialog.overlay.fadeIn('fast', function () {
                    dialog.container.slideDown('slow', function () {
                        dialog.data.fadeIn('slow');
                    });
                });
            }, onClose: function (dialog) {
                dialog.data.fadeOut('slow', function () {
                    dialog.container.slideUp('slow', function () {
                        dialog.overlay.fadeOut('slow', function () {
                            $.modal.close(); // must call this!
                        });
                    });
                });
            }
        });
    });

    $('#releaseQA').bind('click', function () {
        $("#cmp_ReleaseIssueQA_ModalWindow").modal({
            zIndex: 777, opacity: 50, overlayCss: { backgroundColor: "#000000" }, onOpen: function (dialog) {
                dialog.overlay.fadeIn('fast', function () {
                    dialog.container.slideDown('slow', function () {
                        dialog.data.fadeIn('slow');
                    });
                });
            }, onClose: function (dialog) {
                dialog.data.fadeOut('slow', function () {
                    dialog.container.slideUp('slow', function () {
                        dialog.overlay.fadeOut('slow', function () {
                            $.modal.close(); // must call this!
                        });
                    });
                });
            }
        });
    });

    $('#reopen').bind('click', function () {
        $("#cmp_ReOpenIssue_ModalWindow").modal({
            zIndex: 777, opacity: 50, overlayCss: { backgroundColor: "#000000" }, onOpen: function (dialog) {
                dialog.overlay.fadeIn('fast', function () {
                    dialog.container.slideDown('slow', function () {
                        dialog.data.fadeIn('slow');
                    });
                });
            }, onClose: function (dialog) {
                dialog.data.fadeOut('slow', function () {
                    dialog.container.slideUp('slow', function () {
                        dialog.overlay.fadeOut('slow', function () {
                            $.modal.close(); // must call this!
                        });
                    });
                });
            }
        });
    });

    $('#issueTable tbody tr td img').bind('click', function () {
        $("#cmp_EditIssue_ModalWindow").modal({
            zIndex: 777, opacity: 50, overlayCss: { backgroundColor: "#000000" }, onOpen: function (dialog) {
                dialog.overlay.fadeIn('fast', function () {
                    dialog.container.slideDown('slow', function () {
                        dialog.data.fadeIn('slow');
                    });
                });
            }, onClose: function (dialog) {
                dialog.data.fadeOut('slow', function () {
                    dialog.container.slideUp('slow', function () {
                        dialog.overlay.fadeOut('slow', function () {
                            $.modal.close(); // must call this!
                        });
                    });
                });
            }
        });
    });
});

