var issueTable;
$(document).ready(function () {
    InitializePageData();
    
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

    $('#issueTable tbody tr img.edit').live('click', function () {
        PopulateIssueDetailsForEditing(this, issueTable);
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

    $('#cmp_btn_AddIssue_Save').bind('click', function () {
        AddNewIssue();
    });

});

function InitializePageData() {
    //Initialize the issue table
    issueTable = $('#issueTable').dataTable({ "bAutoWidth": false, "bPaginate": true, "bJQueryUI": false, "sPaginationType": "full_numbers", "oLanguage": { "sSearch": "Search:" }, "iDisplayLength": 10, "aaSorting": [[1, "asc"]] });
    PopulateIssues();
    PopulateIssueCategory();
    PopulateTenants();
}

// Bind the tenant details to a dropdowns
function PopulateTenants() {
    var project = "ROD Config";
    $.ajax({
        type: "GET",
        url: "http://localhost:58298/api/Issue/GetTenantByProject/" + project,
        //data: '{"ProjectName":"' + project + '"}',
        contentType: "application/json; charset=utf-8",
        async: true,
        crossDomain: true,
        dataType: "json",
        success: function (data) {
            if (data.length > 0) {
                $("#cmp_AddIssue_Select_Tenant").get(0).options.length = 0;
                $("#cmp_AddIssue_Select_Tenant").get(0).options[0] = new Option("Select", "-1");
                $("#cmp_EditIssue_Select_Tenant").get(0).options.length = 0;
                $("#cmp_EditIssue_Select_Tenant").get(0).options[0] = new Option("Select", "-1");
                $.each(data, function (index, item) {
                    $("#cmp_AddIssue_Select_Tenant").get(0).options[$("#cmp_AddIssue_Select_Tenant").get(0).options.length] = new Option(item.TenantName, item.Id);
                    $("#cmp_EditIssue_Select_Tenant").get(0).options[$("#cmp_EditIssue_Select_Tenant").get(0).options.length] = new Option(item.TenantName, item.Id);
                });
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            var err = eval("(" + XMLHttpRequest.responseText + ")");
            alert(err.Message);
        }
    });
}
// Bind the Issue category details to a dropdowns
function PopulateIssueCategory() {
    $.ajax({
        type: "GET",
        url: "http://localhost:58298/api/Issue/GetAllIssueCategoryType",
        contentType: "application/json; charset=utf-8",
        async: true,
        crossDomain: true,
        dataType: "json",
        success: function (data) {
            if (data.length > 0) {
                $("#cmp_EditIssue_Select_IssueCategory").get(0).options.length = 0;
                $("#cmp_EditIssue_Select_IssueCategory").get(0).options[0] = new Option("Select", "-1");
                $.each(data, function (index, item) {
                    $("#cmp_EditIssue_Select_IssueCategory").get(0).options[$("#cmp_EditIssue_Select_IssueCategory").get(0).options.length] = new Option(item.CategoryName, item.Id);
                });
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            var err = eval("(" + XMLHttpRequest.responseText + ")");
            alert(err.Message);
        }
    });
}
//Adds a newly logged issue
function AddNewIssue()
{
    $('#cmp_btn_AddIssue_Save').ajaxStart(function () {
        $('#cmp_btn_AddIssue_Save').attr("disabled", true);
        $('#cmp_AddIssue_ajaxProcessing').show();
    });
    $('#cmp_btn_AddIssue_Save').ajaxComplete(function () { $('#cmp_btn_AddIssue_Save').attr("disabled", false); $('#cmp_AddIssue_ajaxProcessing').hide(); });
    var isValid = ValidateDataForAddNewIssue();
    if (isValid == false) {
        $('#cmp_AddIssue_ErrorMessage').html("We are sorry, but the highlighted fileds are missing or incorrect.");
        $('#cmp_AddIssue_ErrorImage').attr("src", "../Images/dataValidation_Error.png");
        $('#cmp_AddIssue_dataValidation_Error').show();
    }
    else {
        var newIssueDetails = {
            IssueType: $('#cmp_AddIssue_Select_IssueType option:selected').text(),
            ExternalId: $('#cmp_AddIssue_txtbox_Ticket').val(),
            Summary: $('#cmp_AddIssue_txtarea_IssueSummary').val(),
            Priority: $('#cmp_AddIssue_Select_IssuePriority option:selected').text(),
            CreatedBy: "bkpabi@gmail.com",
            TenantId: $('#cmp_AddIssue_Select_Tenant').val()
        };

        $.ajax({
            type: "POST",
            url: "http://localhost:58298/api/Issue/AddNewIssue",
            data: JSON.stringify(newIssueDetails),
            contentType: "application/json; charset=utf-8",
            async: true,
            crossDomain: true,
            dataType: "json",
            success: function (data) {
                $('#cmp_AddIssue_Select_IssueType').val("-1");
                $('#cmp_AddIssue_txtbox_Ticket').val("");
                $('#cmp_AddIssue_txtarea_IssueSummary').val("");
                $('#cmp_AddIssue_Select_IssuePriority').val("-1");
                $('#cmp_AddIssue_Select_Tenant').val("-1");
                $('#cmp_AddIssue_ErrorImage').attr("src", "../Images/checkmark-26.png");
                $('#cmp_AddIssue_ErrorMessage').html('Issue ' + $('#cmp_AddIssue_txtbox_Ticket').val() + ' added successfully');
                $('#cmp_AddIssue_dataValidation_Error').show();
                $('#cmp_AddIssue_dataValidation_Error').delay(5000).fadeOut(400);

            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                var err = eval("(" + XMLHttpRequest.responseText + ")");
                $('#cmp_AddIssue_ErrorImage').attr("src", "../Images/dataValidation_Error.png");
                if (err.Message == "Invalid") {
                    $('#cmp_AddIssue_ErrorMessage').html('Some thing went wrong while processing the request. Please try after some time.');
                }
                else {
                    $('#cmp_AddIssue_ErrorMessage').html(err.Message);
                }
                $('#cmp_AddIssue_dataValidation_Error').show();
                $('#cmp_AddIssue_dataValidation_Error').delay(5000).fadeOut(400);
            }
        });
    }
}
//Validate data for new issue.
function ValidateDataForAddNewIssue() {
    //--Tenant
    var isValid = true;
    if ($('#cmp_AddIssue_Select_Tenant').val() == "-1") {
        $('#cmp_AddIssue_Lable_Tenant').css({ "color": "red" });
        isValid = false;
    }
    else { $('#cmp_AddIssue_Lable_Tenant').css({ "color": "" }); }

    //--Ticket
    if (!ValidateRequiredField($('#cmp_AddIssue_txtbox_Ticket').val())) {
        $('#cmp_AddIssue_Lable_Ticket').css({ "color": "red" });
        isValid = false;
    }
    else { $('#cmp_AddIssue_Lable_Ticket').css({ "color": "" }); }

    //--Issue Type
    if ($('#cmp_AddIssue_Select_IssueType').val() == "-1") {
        $('#cmp_AddIssue_Lable_Type').css({ "color": "red" });
        isValid = false;
    }
    else { $('#cmp_AddIssue_Lable_Type').css({ "color": "" }); }

    //--Issue Priority
    if ($('#cmp_AddIssue_Select_IssuePriority').val() == "-1") {
        $('#cmp_AddIssue_Lable_Priority').css({ "color": "red" });
        isValid = false;
    }
    else { $('#cmp_AddIssue_Lable_Priority').css({ "color": "" }); }

    //--Issue Summary
    if (!ValidateRequiredField($('#cmp_AddIssue_txtarea_IssueSummary').val())) {
        $('#cmp_AddIssue_Lable_Summary').css({ "color": "red" });
        isValid = false;
    }
    else { $('#cmp_AddIssue_Lable_Summary').css({ "color": "" }); }

    return isValid;
}

function PopulateIssues() {
    var projectName = "ROD Config";
    $.ajax({
        type: "GET",
        url: "http://localhost:58298/api/Issue/GetAllIssuesByProject/" + projectName,
        //data: '{"ProjectName":"' + project + '"}',
        contentType: "application/json; charset=utf-8",
        async: true,
        crossDomain: true,
        dataType: "json",
        success: function (data) {
            if (data.length > 0) {
                //issueTable.fnClearTable();
                $.each(data, function (index, item) {
                    var newRow = '<tr><td><input type="checkbox" id="' + item.Id + '" /></td><td><a href="IssueDetail.aspx?p='+item.ExternalId+'">' + item.ExternalId + '</a></td><td>' + item.Summary + '</td><td>' + item.TenantName + '</td><td>' + item.CategoryName + '</td><td>' + item.Status + '</td><td><img title="Edit" style="cursor:pointer;width:18px; height:18px;" alt="" src="../Images/edit-26.png" class="edit" /></td></tr>';
                    issueTable.fnAddTr($(newRow)[0]);
                });
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            var err = eval("(" + XMLHttpRequest.responseText + ")");
            alert(err.Message);
        }
    });
}

function PopulateIssueDetailsForEditing(event, issueTable) {
    // Issue id is strored as the id of the checkbox, so we need to get the issue id inorder to get the details
    var rowindex = issueTable.fnGetPosition(event.parentNode.parentNode);
    var issueId = issueTable.fnGetNodes(rowindex).firstChild.firstChild.attributes[1].nodeValue;
    $.ajax({
        type: "GET",
        url: "http://localhost:58298/api/Issue/GetIssueDetailsById/" + issueId,
        contentType: "application/json; charset=utf-8",
        async: true,
        crossDomain: true,
        dataType: "json",
        success: function (data) {
            $("#cmp_EditIssue_Select_Tenant option:contains(" + data.TenantName + ")").attr('selected', 'selected');
            $('#cmp_EditIssue_txtbox_Ticket').val(data.ExternalId);
            $("#cmp_EditIssue_Select_IssueType option:contains(" + data.IssueType + ")").attr('selected', 'selected');
            $("#cmp_EditIssue_Select_IssueCategory option:contains(" + data.CategoryName + ")").attr('selected', 'selected');
            $("#cmp_EditIssue_Select_IssuePriority option:contains(" + data.Priority + ")").attr('selected', 'selected');
            $('#cmp_EditIssue_txtarea_IssueSummary').text(data.Summary);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            var err = eval("(" + XMLHttpRequest.responseText + ")");
            alert(err.Message);
        }
    });
}

