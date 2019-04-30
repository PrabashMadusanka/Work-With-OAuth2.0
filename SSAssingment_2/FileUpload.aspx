<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="SSAssingment_2.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        table
        {
            border: 1px solid #ccc;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border-color: #ccc;
        }
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
    File:
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <br />
    Description:<br />
    <asp:TextBox ID="txtDescription" runat="server" Width="300"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="UploadFile" />
    <hr />
    <table id="tblFileDetails" runat="server" visible="false" border="0" cellpadding="0"
        cellspacing="0">
        <tr>
            <td class="auto-style1">
                Title
            </td>
            <td class="auto-style1">
                <asp:Label ID="lblTitle" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Id
            </td>
            <td>
                <asp:Label ID="lblId" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Icon
            </td>
            <td>
                <asp:Image ID="imgIcon" runat="server" />
            </td>
        </tr>
        <tr id="rowThumbnail" runat="server" visible="false">
            <td valign="top">
                Thumbnail
            </td>
            <td>
                <asp:Image ID="imgThumbnail" runat="server" Height="60" Width="60" />
            </td>
        </tr>
        <tr>
            <td>
                Created Date
            </td>
            <td>
                <asp:Label ID="lblCreatedDate" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Download
            </td>
            <td>
                <asp:HyperLink ID="lnkDownload" Text="Download" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
