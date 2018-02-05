<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="gameSummaryLabel" Text="" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="numberOfPlayersLabel" Text="Enter number of players: " AssociatedControlID="numberOfPlayersTextBox" runat="server"></asp:Label>
            <asp:TextBox ID="numberOfPlayersTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="playGameButton" Text="Play Game" runat="server" OnClick="PlayGameButtonClick" />
        </div>
    </form>
</body>
</html>
