<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WeSay.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button2">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                当前在线人数：<asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                人<br />
                <asp:TextBox ID="TextM" runat="server" Height="281px" Width="276px" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <asp:Button ID="ButtonName" runat="server" OnClick="ButtonName_Click" Text="点此改名" Width="81px" />
        <asp:TextBox ID="TextBoxName" runat="server" Visible="False" Width="81px" onMouseOver="this.focus();this.select()" OnTextChanged="TextBoxName_TextChanged" style="height: 23px">点此改名</asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="发送" />
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="取消" Visible="False" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="确定" Visible="False" />
        </p>
    </form>
</body>
</html>
