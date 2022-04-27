<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="text-center">Employee List</h1>
    <br />
    <asp:HyperLink runat="server" NavigateUrl="~/Add.aspx">Add new employee</asp:HyperLink>
    <asp:GridView ID="EmployeeGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-table-bordered">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="id"/>
            <asp:BoundField HeaderText="Nama depan" DataField="firstname"/>
            <asp:BoundField HeaderText="Nama belakang" DataField="lastname" />
            <asp:BoundField HeaderText="Email" DataField="email" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink runat="server" NavigateUrl='<%# "~/Edit.aspx?id=" + DataBinder.Eval(Container.DataItem, "id") %>'>Edit</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
