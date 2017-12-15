<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="chcheck-test.aspx.cs" Inherits="WebAppCHD.admin.chcheck_test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <input class="form-control" id="myInput" type="text" placeholder="Search..">
                        <br>
     <table class="scroll w3-table-all w3-hoverable" width="100%">
                            <thead>
                                <tr>
                                     <th>All</th>
                                    <th>ID</th>
                                    <th>Môn</th>
                                    <th>Nôi dung</th>
                                    <th>Câu A</th>
                                    <th>Câu B</th>
                                    <th>Câu C</th>
                                    <th>Câu D</th>
                                    <th>Câu đúng</th>
                                    <th>Loại</th>
                                </tr>
                                
                            </thead>
                            <tbody id="myTable">
                                <asp:Repeater ID="RptTest" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                               <asp:CheckBox ID="CheckBox1" runat="server" /> </td>
                                            <td>
                                                <asp:Label ID="lbID" runat="server" Text='<%#Eval("IDTest") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblmon" runat="server" Text='<%#Eval("NameSub") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("TestContent") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("TestA") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lbltrue" runat="server" Text='<%#Eval("TestB") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblTT" runat="server" Text='<%#Eval("TestC") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblphan" runat="server" Text='<%#Eval("TestD") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblchuong" runat="server" Text='<%#Eval("TestCorrect") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("NameTT") %>'></asp:Label></td>
                                            <td>
                                               
                                                <asp:LinkButton ID="lbtselect" runat="server" CommandArgument='<%#Eval("IDTest") %>' CommandName="Select">Select</asp:LinkButton></td>
                                        </tr>
                                        <tr>
                                            <asp:Label ID="lblct" runat="server" Text=""></asp:Label>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                        <script>
                            $(document).ready(function () {
                                $("#myInput").on("keyup", function () {
                                    var value = $(this).val().toLowerCase();
                                    $("#myTable tr").filter(function () {
                                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                                    });
                                });
                            });
                        </script>
    <div class="row">
        <div class="col-sm-4"></div>
        <div class="col-sm-8"></div>
    </div>
</asp:Content>
