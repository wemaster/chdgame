<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppCHD.admin.Default" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-sm-12">
            <div class="w3-container">
                <label>Nội dung câu hỏi</label><br />
                 <asp:Label ID="lbltext" runat="server"></asp:Label>
                <CKEditor:CKEditorControl ID="CKEditor1" BasePath="~/admin/ckeditor/" runat="server" Height="84px"></CKEditor:CKEditorControl>
               
                <asp:Button ID="btnreview" runat="server" Text="Review" OnClick="btnreview_Click" />
                <br />
                <div class="row">
                    <div class="col-sm-4">
                        <label>Đáp án A:</label>
                        <asp:TextBox ID="txtDAA" class="w3-input w3-border w3-animate-input" Style="width: 30%" runat="server"></asp:TextBox>

                        <br />

                        <label>Đáp án B:</label>
                        <asp:TextBox ID="txtDAB" class="w3-input w3-border w3-animate-input" Style="width: 30%" runat="server"></asp:TextBox>

                        <br />

                        <label>Đáp án C:</label>
                        <asp:TextBox ID="txtDAC" class="w3-input w3-border w3-animate-input" Style="width: 30%" runat="server"></asp:TextBox>

                        <br />

                        <label>Đáp án D:</label>
                        <asp:TextBox ID="txtDAD" class="w3-input w3-border w3-animate-input" Style="width: 30%" runat="server"></asp:TextBox>

                        <br />

                        <label class="w3-margin">Thời gian:</label>
                        <asp:TextBox ID="txtminnutes" runat="server" Width="60px">02:00</asp:TextBox>
                    </div>
                    <div class="col-sm-8">
                        <input class="form-control" id="myInput" type="text" placeholder="Search..">
                        <br>
                        <table class="scroll w3-table-all w3-hoverable" width="100%">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Môn</th>
                                    <th>Câu đúng</th>
                                    <th>Trạng thái</th>
                                    <th>Phần</th>
                                    <th>Chương</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody id="myTable">
                                <asp:Repeater ID="RptTest" runat="server" OnItemCommand="RptTest_ItemCommand">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lbID" runat="server" Text='<%#Eval("IDTest") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblmon" runat="server" Text='<%#Eval("NameSub") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lbltrue" runat="server" Text='<%#Eval("TestCorrect") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblTT" runat="server" Text='<%#Eval("NameTT") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblphan" runat="server" Text='<%#Eval("IDPhan") %>'></asp:Label></td>
                                            <td>
                                                <asp:Label ID="lblchuong" runat="server" Text='<%#Eval("IDChuong") %>'></asp:Label></td>
                                            <td>
                                               
                                                <asp:LinkButton ID="lbtselect" runat="server" CommandArgument='<%#Eval("IDTest") %>' CommandName="Select">Select</asp:LinkButton></td>
                                        </tr>
                                        <tr>
                                            <asp:Label ID="lblct" runat="server" Text=""></asp:Label>
                                             <asp:HiddenField ID="lblcontent" Value='<%#Eval("TestContent") %>' runat="server" />
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
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-4  text-right">
                        <label class="w3-margin">Đáp án đúng</label>
                        <asp:DropDownList ID="drTest" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="A">Đáp án A</asp:ListItem>
                            <asp:ListItem Value="B">Đáp án B</asp:ListItem>
                            <asp:ListItem Value="C">Đáp án C</asp:ListItem>
                            <asp:ListItem Value="D">Đáp án D</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-4  text-right">
                        <label class="w3-margin">Môn học</label>
                        <asp:DropDownList ID="DrSub" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="1">Toán</asp:ListItem>
                            <asp:ListItem Value="2">Lý</asp:ListItem>
                            <asp:ListItem Value="3">Hóa</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-4  text-right">
                        <label class="w3-margin">Lớp</label>
                        <asp:DropDownList ID="DropDownList1" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="1">10</asp:ListItem>
                            <asp:ListItem Value="2">11</asp:ListItem>
                            <asp:ListItem Value="3">12</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4  text-right">
                        <label class="w3-margin">Loại</label>
                        <asp:DropDownList ID="drdloai" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="6">Đấu máy</asp:ListItem>
                            <asp:ListItem Value="2">Đấu đơn</asp:ListItem>
                            <asp:ListItem Value="3">Đấu xếp hạng</asp:ListItem>
                            <asp:ListItem Value="6">Đấu Event</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                     <div class="col-sm-4  text-right">
                        <label class="w3-margin">Phần</label>
                        <asp:DropDownList ID="DrPhan" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="1">Phần I</asp:ListItem>
                            <asp:ListItem Value="2">Phần II</asp:ListItem>
                            <asp:ListItem Value="3">Phần III</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-4  text-right">
                        <label class="w3-margin">Chương</label>
                        <asp:DropDownList ID="DrChuong" runat="server" class="btn btn-primary dropdown-toggle">
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="1">4</asp:ListItem>
                            <asp:ListItem Value="2">5</asp:ListItem>
                            <asp:ListItem Value="3">6</asp:ListItem>
                            <asp:ListItem Value="1">7</asp:ListItem>
                            <asp:ListItem Value="2">8</asp:ListItem>
                            <asp:ListItem Value="3">9</asp:ListItem>
                            <asp:ListItem Value="1">10</asp:ListItem>
                            <asp:ListItem Value="2">11</asp:ListItem>
                            <asp:ListItem Value="3">12</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>



                <hr />
                <div class="w3-row">
                    <div class="w3-col m2 w3-center">
                        <div class="w3-tag w3-round w3-green" style="padding: 3px">
                            <asp:Button ID="btnsave" runat="server" Text="Save"
                                class="w3-tag w3-round w3-green w3-border w3-border-white" OnClick="btnsave_Click" />
                        </div>
                    </div>
                    <div class="w3-col m2 w3-center">
                        <div class="w3-tag w3-round w3-teal" style="padding: 3px">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" class="w3-tag w3-round w3-teal w3-border w3-border-white" />
                        </div>
                    </div>
                    <div class="w3-col m2 w3-center">
                        <div class="w3-tag w3-round w3-indigo" style="padding: 3px">
                            <asp:Button ID="btndel" runat="server" Text="Delete"
                                class="w3-tag w3-round w3-indigo w3-border w3-border-white" />
                        </div>
                    </div>

                    <div class="w3-col m2 w3-center">
                        <div class="w3-tag w3-round w3-red" style="padding: 3px">
                            <asp:Button ID="btncancel" runat="server" Text="Cancel"
                                class="w3-tag w3-round w3-red w3-border w3-border-white" />
                        </div>
                    </div>
                </div>
                <hr />
               
            </div>
    </div>
    <!-- /.col-lg-8 -->
  
</asp:Content>

