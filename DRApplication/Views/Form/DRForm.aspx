<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DRForm.aspx.cs" Inherits="DRApplication.Views.Form.DRForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .newStyle2
        {
            font-family: Georgia, "Times New Roman", Times, serif;
        }
        #Text1
        {
            text-align: right;
        }
        .auto-style2
        {
            width: 162px;
        }
        .auto-style3
        {
            font-family: Georgia, "Times New Roman", Times, serif;
            width: 279px;
        }
        .auto-style4
        {
            width: 641px;
        }
        .auto-style5
        {
            width: 186px;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="DRForm" runat="server">
    <div style="text-align: center" style="flex-align:center">
    
        <table class="auto-style4" style="flex-align:center">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <h4>OFFICE OF THE SHERIFF </h4>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <h4>DEPARTMENT OF CORRECTIONS </h4>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <h4>DISCIPLINARY REPORT</h4>
                </td>
                <td class="auto-style5">Report #
                    <input id="Text1" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
