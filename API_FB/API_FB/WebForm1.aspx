<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="API_FB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FaceBook API</title>
    <style type="text/css">
        .Load_Data {
            height: 26px;
            background: #F0F2F5;
            margin: 25px;
            padding: 20px;
            border-radius: 3px;
        }
        h2 {
            font-family: 'Helvetica Neue', Arial, Helvetica, sans-serif;
            font-size: 26px;
            color: #ff0000;
        }

        p {
            font-family: 'Helvetica Neue', Arial, Helvetica, sans-serif;
            font-size: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="Load_Data">
                        <asp:Label ID="lbContent" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
