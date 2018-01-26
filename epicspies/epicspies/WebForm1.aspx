<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="epicspies.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="http://learnvisualstudio.kenjlucas.com/WebApps/EpicSpiesChallenge02/epic-spies-logo.jpg" Width="140px" />
        </h1>
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of&nbsp; New Assignment<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
