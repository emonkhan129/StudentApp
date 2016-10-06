<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="StudentApp.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
             <table width="50%">
            <tr>
                <td>
                     <asp:Label runat="server" ID="regLabel" Text="Reg No"></asp:Label>
               </td>
                <td>
                     <asp:TextBox runat="server" ID="regNoTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label runat="server" ID="firstNameLabel" Text="First Name"></asp:Label>
                </td>
                <td>
                     <asp:TextBox runat="server" ID="firstNameTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lastNameLabel" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="lastNameTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Button runat="server" ID="saveButton" Text="Save" OnClick="saveButton_Click"/>
                </td>
                <td>
                    <asp:Button runat="server" ID="showAllButton" Text="Show All" OnClick="showAllButton_Click"/>
                </td>
            </tr>
        </table>
    </div>
        <p>
            <asp:Label ID="outputLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
