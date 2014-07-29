<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="IssueDetails.aspx.cs" Inherits="Compass.UI.WebApp.TeamLead.IssueDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Issue Details | Compass
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../Themes/StyleSheets/teamlead_Issuedetails.css" rel="stylesheet" />
    <script src="../Themes/Scripts/DataTable/js/jquery.dataTables.js"></script>
    <script src="../Themes/Scripts/TeamLead_IssueDetails.js"></script>
    <link href="../Themes/Scripts/DataTable/css/demo_table_jui.css" rel="stylesheet" />
    <script src="../Themes/Scripts/jquery.simplemodal.1.4.1.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div id="leftNav">
        <ul>
            <li><a href="Overview.aspx" >Overview</a></li>
            <li class="active"><a href="IssueDetails.aspx">Issues</a></li>
        </ul>
    </div>
    <div id="rightBody">
        <div id="topBar">
            <div style="float:left; width:400px;">
            <div style="height:32px;margin-top:5px; font-weight:400;"><img src="../Images/issueSummary.png" style="float:left;"/>&nbsp;&nbsp;<span style="font-weight:600;">Issue Summary</span></div>
            <div class="styled-select" style="float:left; height:75px; margin-top:3px;">
            <select id="FilterOption" class="select">
                <option value="1">All</option>
                <option value="2">This weeks issues</option>
                <option value="3">Reopen issues</option>
            </select> 
            <input type="button" name="Show" value="Show" class="button" style="margin-top:0px;" />
            </div>
                </div>
            <div id="actions" style="float:right; width:500px;">
                <ul style="float:right; list-style:none;">
                    <li id="logissue"><div style="text-align:center"><img src="../Images/plus-26.png" /></div><div>Log Issue</div></li>
                    <li id="assignTo"><div style="text-align:center"><img src="../Images/link-26.png" /></div><div>Assign Issue</div></li>
                    <li id="releaseQA"><div style="text-align:center"><img src="../Images/release.png" /></div><div>Release QA</div></li>
                    <li id="reopen"><div style="text-align:center"><img src="../Images/empty_box-26.png" /></div><div>Reopen Issue</div></li>
                    <li><div style="text-align:center"><img src="../Images/full_trash-26.png" /></div><div>Delete</div></li>
                    
                </ul>
                
            </div>
        </div>
        <div id="IssueDetails">
            <div class="issueTableContainer">
            <table id="issueTable" class="grid">
                <thead>
                    <tr>
                        <th><input type="checkbox" /></th>
                        <th>Issue Id</th>
                        <th>Summary</th>
                        <th>Tenant</th>
                        <th>Category</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC001</a></td>
                        <td>Add Offer functioanlity not working</td>
                        <td>Blackboard</td>
                        <td>Need to work</td>
                        <td>Open</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC002</a></td>
                        <td>Add Offer functioanlity not working.Add Offer functioanlity not working.Add Offer functioanlity not working.Add Offer functioanlity not working.Add Offer functioanlity not working.Add Offer functioanlity not working.Add Offer functioanlity not working</td>
                        <td>Blackboard</td>
                        <td>Need to work</td>
                        <td>Open</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC003</a></td>
                        <td>Need sales rep relation in edit multiple</td>
                        <td>Viewpoints</td>
                        <td>Need to work</td>
                        <td>Released to QA</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC001</a></td>
                        <td>Add Offer functioanlity not working</td>
                        <td>Blackboard</td>
                        <td>Need to work</td>
                        <td>Open</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC002</a></td>
                        <td>Fields missing</td>
                        <td>Aspect</td>
                        <td>Need to work</td>
                        <td>Open</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                    <tr>
                        <td><input type="checkbox" /> </td>
                        <td><a href="Overview.aspx">SFDC003</a></td>
                        <td>Add Offer functioanlity not working</td>
                        <td>Blackboard</td>
                        <td>Need to work</td>
                        <td>Open</td>
                        <td><img src="../Images/edit-26.png" style="width:18px; height:18px;" /> </td>
                    </tr>
                </tbody>
            </table>
                </div>
            <div id="activity"><img src="../Images/heart_monitor-26.png" style="float:left;" /><span style="padding-left:10px; font-weight:600;">Activity</span>
                <ul>
                    <li><img src="../Images/today-26.png" style="float:left; margin-right:8px;" />Pabitra Ray has assigned Issue #SFDC302 to QA</li>
                    <li><img src="../Images/today-26.png" style="float:left; margin-right:8px;" />Inder Swami has passed Issue #SFDC322</li>
                    <li><img src="../Images/today-26.png" style="float:left; margin-right:8px;" />You have released 10 issues to proserve</li>
                </ul>
            </div>
        </div>
    </div>
<div id="cmp_AddIssue_ModalWindow">
    <div id="cmp_AddIssue_ModalWindow_InnerContainer" style="">
        <div id="cmp_AddIssue_ModalWindow_InnerContainer_ModalHeader">
            <span>Log an Issue</span><span style="float:right; color:#AD382D; margin-right:35px; font-size:12px; padding-top:5px;">*mandatory</span>
        </div>
        <div id="cmp_AddIssue_ModalWindow_InnerContainer_DataContainer"> 
            <table border="0">
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Tenant" class="cmp_lable">&nbsp;&nbsp;&nbsp;Tenant:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><select id="cmp_AddIssue_Select_Tenant" class="planix_selectMedium"><option value="1">Aspect</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_Tenant"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Ticket" class="cmp_lable">&nbsp;&nbsp;&nbsp;Ticket #:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><input id="cmp_AddIssue_txtbox_Ticket" class="planix_textBoxMedium" type="text"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_Ticket"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Type" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue Type:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_AddIssue_Select_IssueType" class="planix_selectMedium"><option value="1">SFDC</option><option value="2">Rally</option><option value="3">Manual</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_IssueType"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Category" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue Category:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_AddIssue_Select_IssueCategory" class="planix_selectMedium"><option value="1">Need to work</option><option value="2">Product Engineering</option><option value="3">Need More Details</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_IssueCategoty"></span></td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Priority" class="cmp_lable">&nbsp;&nbsp;&nbsp;Priority:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_AddIssue_Select_IssuePriority" class="planix_selectMedium"><option value="1">Highest</option><option value="2">Medium</option><option value="3">Low</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_IssuePriority"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AddIssue_Lable_Summary" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue summary:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <%--<input id="planix_AddIncome_Txtbox_Note" class="planix_textBoxMedium" type="text" />--%><textarea id="cmp_AddIssue_txtarea_IssueSummary" rows="2" cols="20"></textarea></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AddIssue_IssueSummary"></span> </td>
                </tr>
            </table>
        </div>
        <div id="cmp_AddIssue_ModalWindow_InnerContainer_ModalFooter">
            <div id="cmp_AddIssue_ajaxProcessing"><img alt="ajaxloader" src="/Images/3.gif"/>&nbsp;&nbsp; Please wait...</div>
            <div style="float:right;margin-top:5px; margin-right:4px;">
            <div style="display:none;float:left;" id="planix_AddIncome_dataValidation_Error">
            <img alt="" id="cmp_AddIssue_ErrorImage" src="../Images/cry.png" style="float:left" />
            <span id="cmp_AddIssue_ErrorMessage" style="float:left; color:#333333;line-height:13px;margin-top:3px; margin-right:7px;"></span>
            </div>
                <button type="button" id="cmp_btn_Income_Save" class="planix_button_Save">Save</button>
            </div>
        </div>
    </div>
</div>

<div id="cmp_AssignIssue_ModalWindow">
    <div id="cmp_AssignIssue_ModalWindow_InnerContainer" style="">
        <div id="cmp_AssignIssue_ModalWindow_InnerContainer_ModalHeader">
            <span>Assign issue to developer</span><span style="float:right; color:#AD382D; margin-right:35px; font-size:12px; padding-top:5px;">*mandatory</span>
        </div>
        <div id="cmp_AssignIssue_ModalWindow_InnerContainer_DataContainer"> 
            <table border="0">
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_AssignIssue_Lable_Tenant" class="cmp_lable">&nbsp;&nbsp;&nbsp;Assign to:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><select id="cmp_AddIssue_Select_AssignTo" class="planix_selectMedium" style="width:250px;"><option value="1">Pabitra</option><option value="1">Balaganesh</option></select></td>
                </tr>
                <tr style="height:130px;">
                    <td style="width:150px;">
                        <img src="../Images/guest-128.png" /></td>
                    <td><span style="float:left; width:98%; font-size:6em; font-weight:500; color:#14a431; line-height:1;">10</span>
                        <span style="color:#b1aeae; font-size:small;">Issues assigned</span></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_AssignIssue_AssignTo"></span> </td>
                </tr>
            </table>
        </div>
        <div id="cmp_AssignIssue_ModalWindow_InnerContainer_ModalFooter">
            <div id="cmp_AssignIssue_ajaxProcessing"><img alt="ajaxloader" src="/Images/3.gif"/>&nbsp;&nbsp; Please wait...</div>
            <div style="float:right;margin-top:5px; margin-right:4px;">
            <div style="display:none;float:left;" id="planix_AssignIncome_dataValidation_Error">
            <img alt="" id="cmp_AssignIssue_ErrorImage" src="../Images/cry.png" style="float:left" />
            <span id="cmp_AssignIssue_ErrorMessage" style="float:left; color:#333333;line-height:13px;margin-top:3px; margin-right:7px;"></span>
            </div>
                <button type="button" id="cmp_btn_Assign_Save" class="planix_button_Save">Assign</button>
            </div>
        </div>
    </div>
</div>

<div id="cmp_ReleaseIssueQA_ModalWindow">
    <div id="cmp_ReleaseIssueQA_ModalWindow_InnerContainer" style="">
        <div id="cmp_ReleaseIssueQA_ModalWindow_InnerContainer_ModalHeader">
            <span>Release Issue to QA</span><span style="float:right; color:#AD382D; margin-right:35px; font-size:12px; padding-top:5px;">*mandatory</span>
        </div>
        <div id="cmp_ReleaseIssueQA_ModalWindow_InnerContainer_DataContainer"> 
            <table border="0">
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_ReleaseIssueQA_Lable_TestCase" class="cmp_lable">&nbsp;&nbsp;&nbsp;Test case:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><textarea id="cmp_ReleaseIssueQA_txtarea_Testcase" rows="2" cols="20"></textarea></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_ReleaseIssueQA_AssignTo"></span> </td>
                </tr>
            </table>
        </div>
        <div id="cmp_ReleaseIssueQA_ModalWindow_InnerContainer_ModalFooter">
            <div id="cmp_ReleaseIssueQA_ajaxProcessing"><img alt="ajaxloader" src="/Images/3.gif"/>&nbsp;&nbsp; Please wait...</div>
            <div style="float:right;margin-top:5px; margin-right:4px;">
            <div style="display:none;float:left;" id="planix_ReleaseIssueQA_dataValidation_Error">
            <img alt="" id="cmp_ReleaseIssueQA_ErrorImage" src="../Images/cry.png" style="float:left" />
            <span id="cmp_ReleaseIssueQA_ErrorMessage" style="float:left; color:#333333;line-height:13px;margin-top:3px; margin-right:7px;"></span>
            </div>
                <button type="button" id="cmp_btn_Release_Save" class="planix_button_Save">Release</button>
            </div>
        </div>
    </div>
</div>

<div id="cmp_ReOpenIssue_ModalWindow">
    <div id="cmp_ReOpenIssue_ModalWindow_InnerContainer" style="">
        <div id="cmp_ReOpenIssue_ModalWindow_InnerContainer_ModalHeader">
            <span>Reopen Issue</span><span style="float:right; color:#AD382D; margin-right:35px; font-size:12px; padding-top:5px;">*mandatory</span>
        </div>
        <div id="cmp_ReOpenIssue_ModalWindow_InnerContainer_DataContainer"> 
            <table border="0">
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_ReOpenIssue_Lable_Reason" class="cmp_lable">&nbsp;&nbsp;&nbsp;Reason:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><textarea id="cmp_ReOpenIssue_txtarea_Reason" rows="2" cols="20"></textarea></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_ReOpenIssue_AssignTo"></span> </td>
                </tr>
            </table>
        </div>
        <div id="cmp_ReOpenIssue_ModalWindow_InnerContainer_ModalFooter">
            <div id="cmp_ReOpenIssue_ajaxProcessing"><img alt="ajaxloader" src="/Images/3.gif"/>&nbsp;&nbsp; Please wait...</div>
            <div style="float:right;margin-top:5px; margin-right:4px;">
            <div style="display:none;float:left;" id="planix_ReOpenIssue_dataValidation_Error">
            <img alt="" id="cmp_ReOpenIssue_ErrorImage" src="../Images/cry.png" style="float:left" />
            <span id="cmp_ReOpenIssue_ErrorMessage" style="float:left; color:#333333;line-height:13px;margin-top:3px; margin-right:7px;"></span>
            </div>
                <button type="button" id="cmp_btn_Reopen_Save" class="planix_button_Save">Reopen</button>
            </div>
        </div>
    </div>
</div>

<div id="cmp_EditIssue_ModalWindow">
    <div id="cmp_EditIssue_ModalWindow_InnerContainer" style="">
        <div id="cmp_EditIssue_ModalWindow_InnerContainer_ModalHeader">
            <span>Log an Issue</span><span style="float:right; color:#AD382D; margin-right:35px; font-size:12px; padding-top:5px;">*mandatory</span>
        </div>
        <div id="cmp_EditIssue_ModalWindow_InnerContainer_DataContainer"> 
            <table border="0">
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Tenant" class="cmp_lable">&nbsp;&nbsp;&nbsp;Tenant:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><select id="cmp_EditIssue_Select_Tenant" class="planix_selectMedium"><option value="1">Aspect</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_Tenant"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Ticket" class="cmp_lable">&nbsp;&nbsp;&nbsp;Ticket #:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td><input id="cmp_EditIssue_txtbox_Ticket" class="planix_textBoxMedium" type="text"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_Ticket"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Type" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue Type:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_EditIssue_Select_IssueType" class="planix_selectMedium"><option value="1">SFDC</option><option value="2">Rally</option><option value="3">Manual</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_IssueType"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Category" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue Category:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_EditIssue_Select_IssueCategory" class="planix_selectMedium"><option value="1">Need to work</option><option value="2">Product Engineering</option><option value="3">Need More Details</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_IssueCategoty"></span></td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Priority" class="cmp_lable">&nbsp;&nbsp;&nbsp;Priority:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <select id="cmp_EditIssue_Select_IssuePriority" class="planix_selectMedium"><option value="1">Highest</option><option value="2">Medium</option><option value="3">Low</option></select></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_IssuePriority"></span> </td>
                </tr>
                <tr class="data">
                    <td style="width:150px;"><span id="cmp_EditIssue_Lable_Summary" class="cmp_lable">&nbsp;&nbsp;&nbsp;Issue summary:</span><span style="color:Red;">&nbsp;*</span></td>
                    <td> <%--<input id="planix_EditIncome_Txtbox_Note" class="planix_textBoxMedium" type="text" />--%><textarea id="cmp_EditIssue_txtarea_IssueSummary" rows="2" cols="20"></textarea></td>
                </tr>
                <tr>
                    <td></td>
                    <td><span id="cmp_Validate_EditIssue_IssueSummary"></span> </td>
                </tr>
            </table>
        </div>
        <div id="cmp_EditIssue_ModalWindow_InnerContainer_ModalFooter">
            <div id="cmp_EditIssue_ajaxProcessing"><img alt="ajaxloader" src="/Images/3.gif"/>&nbsp;&nbsp; Please wait...</div>
            <div style="float:right;margin-top:5px; margin-right:4px;">
            <div style="display:none;float:left;" id="planix_EditIncome_dataValidation_Error">
            <img alt="" id="cmp_EditIssue_ErrorImage" src="../Images/cry.png" style="float:left" />
            <span id="cmp_EditIssue_ErrorMessage" style="float:left; color:#333333;line-height:13px;margin-top:3px; margin-right:7px;"></span>
            </div>
                <button type="button" id="cmp_btn_EditIssue_Save" class="planix_button_Save">Save</button>
            </div>
        </div>
    </div>
</div>
</asp:Content>
