<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebApplication3.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edit employee</h1>

    <table>
        <tr>
            <td>ID</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputID" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>First Name</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputFirstname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputLastname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update employee" OnClick="btnUpdate_Click"/>
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
