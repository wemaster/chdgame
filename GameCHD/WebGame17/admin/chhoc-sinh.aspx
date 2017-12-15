<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="chhoc-sinh.aspx.cs" Inherits="WebAppCHD.admin.chhoc_sinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-row w3-margin">
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
            <input class="form-control" id="myInput" type="text" placeholder="Search..">
            <table class="scroll w3-table-all w3-hoverable">
                <thead>
                    <tr class="w3-light" style="text-align: center; color: white; background-color: #8bc34a !important;">
                        <th class="col-xs-1" align="center">No.</th>
                        <th class="col-xs-3" align="center">Tên</th>
                        <th class="col-xs-2" align="center">Lớp</th>
                        <th class="col-xs-2" align="center">Date</th>
                        <th class="col-xs-2" align="center">Level</th>
                        <th class="col-xs-2" align="center">Điểm</th>
                </thead>
                <tbody id="myTable">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td class="col-xs-1" align="center"><%# Container.ItemIndex + 1 %></td>
                                <td class="col-xs-3">&nbsp;<%#Eval("NameAcc") %></td>
                                <td class="col-xs-2" align="center">&nbsp;<%#Eval("NameClass") %></td>
                                <td class="col-xs-2" align="center"><%#Eval("DateLogin") %></td>
                                <td class="col-xs-2" align="center">
                                    <img id="imglevel" src="img/level/<%#Eval("LevelAcc") %>.png" /></td>
                                <td class="col-xs-2" align="center">&nbsp;<%#Eval("Point") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
</asp:Content>
