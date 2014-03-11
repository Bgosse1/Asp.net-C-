<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style type="text/css">
        .auto-style1 {
            width: 122px;
        }
    </style>
</head>
<body>
      
        

    <form id="form1" runat="server" action="Default.aspx" method="get">    
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate >
    
        
        <table align="center">
            <tr>
                <td><asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox></td>
            </tr>
        </table>
        <table align="center">
            <tr> 
                <td><asp:Button ID="Button1" runat="server" Text="1" OnClick="btn1_Click" Width="31px" /></td>
                <td><asp:Button ID="Button2" runat="server" Text="2" OnClick="btn2_Click" Width="31px" /></td>
                <td><asp:Button ID="Button3" runat="server" Text="3" OnClick="btn3_Click" Width="31px" /></td>
                <td><asp:Button ID="Plus" runat="server" Text="+" OnClick="btnplus_Click" Width="31px" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button4" runat="server" Text="4" OnClick="btn4_Click" Width="31px" /></td>
                <td><asp:Button ID="Button5" runat="server" Text="5" OnClick="btn5_Click" Width="31px" /></td>
                <td><asp:Button ID="Button6" runat="server" Text="6" OnClick="btn6_Click" Width="31px" /></td>
                <td><asp:Button ID="Minus" runat="server" Text="-" OnClick="btnminus_Click" Width="31px" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button7" runat="server" Text="7" OnClick="btn7_Click" Width="31px" /></td>
                <td><asp:Button ID="Button8" runat="server" Text="8" OnClick="btn8_Click" Width="31px" /></td>
                <td><asp:Button ID="Button9" runat="server" Text="9" OnClick="btn9_Click" Width="31px" /></td>
                <td><asp:Button ID="Mult" runat="server" Text="*" OnClick="btnmult_Click" Width="31px" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button0" runat="server" Text="0" OnClick="btn0_Click" Width="31px" /></td>
                <td><asp:Button ID="Dot" runat="server" Text="." OnClick="btndot_Click" Width="31px" /></td>
                <td><asp:Button ID="Equal" runat="server" Text="=" OnClick="btnequal_Click" Width="31px" /></td>
                <td><asp:Button ID="Divide" runat="server" Text="/" OnClick="btndiv_Click" Width="31px" /></td>
            </tr>
        </table>
        <table align="center">
            <tr> 
                <td class="auto-style1"><asp:Button ID="Clear" runat="server" Text="Clear" OnClick="btnclear_Click" Width="137px" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnextend" runat="server" Text=">>" OnClick="btnextend_Click" /></td>
            </tr>
        </table>
        <table align ="center">
            <tr>
                <td><asp:Button ID="btnsin" runat="server" Text="Sin" Visible="false" OnClick="btnsin_Click" /> </td>
                <td><asp:Button ID="btncos" runat="server" Text="Cos" Visible ="false" OnClick="btncos_Click"/> </td>
                <td><asp:Button ID="btntan" runat="server" Text="Tan" Visible ="false" OnClick="btntan_Click" /> </td>
                <td><asp:Button ID="btnmod" runat="server" Text="%" Visible ="false" OnClick="btnmod_Click" Width="22px" /> </td>
            </tr>
        </table>
                 
        Session variable: <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
                 <asp:Button ID="subsol" runat="server" Text="Submit" OnClick="subsol_Click" /><br />
                 <asp:Button ID="clearsv" runat="server" Text="Clear session variable" OnClick="clearsv_Click" />
        </ContentTemplate>
        </asp:UpdatePanel>

    </div>
    </form>
</body>
</html>
