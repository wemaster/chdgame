<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="mem-login.aspx.cs" Inherits="ChDGame.mem_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-9 bgs">
        <!-- Tab menu tướng-->
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Hồ sơ</a></li>
            <li><a data-toggle="tab" href="#menu1">Nhóm giải</a></li>
            <li><a data-toggle="tab" href="#menu2">lịch sử đấu</a></li>
            <li><a data-toggle="tab" href="#menu3">Tướng</a></li>
            <li><a data-toggle="tab" href="#menu4">Pet</a></li>
        </ul>
        <br />
        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">
                <div class="row">
                    <asp:Repeater ID="RptViewAcclogin" runat="server">
                        <ItemTemplate>
                            <div class="col-sm-4">
                                <img class="boanh" src="img/<%#Eval("ImgChamp") %>" height="300px" width="325px" />
                            </div>
                            <div class="col-sm-3">
                                <span class="label label-success w3-margin-top">Point </span>&nbsp
                        <asp:Label ID="lblpoint" runat="server" Text='<%#Eval("Point") %>' ForeColor="Red" Font-Bold="True"></asp:Label>
                                <img src="img/gold/Ph03nyx-Super-Mario-Question-Coin.png" style="width: 30px" />
                                <br />
                                <br />
                                <span class="label label-warning">Level </span>&nbsp
                                <img src="img/level/<%#Eval("LevelAcc") %>.png" />
                                <br />
                                <br />
                                <div class="progress">
                                    <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="0"
                                        aria-valuemin="0" aria-valuemax="100" style="width: <%#Eval("ExpAcc")%>%">
                                        <asp:Label ID="lblexp" runat="server" Text='<%#Eval("ExpAcc") %>' ForeColor="White"></asp:Label>
                                        %
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="col-sm-5">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div class="w3-margin-right">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td style="height: 46px;" colspan="2">
                                                <asp:Button ID="btnChangePwd" runat="server" Text="Đổi mật khảu" OnClick="btnChangePwd_Click" class="btn btn-primary loading" />
                                                <asp:Button ID="btnEditInfo" runat="server" class="btn btn-danger loading" OnClick="btnEditInfo_Click" Text="Chỉnh sửa thông tin" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="color: #FFFFFF;" colspan="2">
                                                <asp:Label ID="lbllop" runat="server" Text="Lớp" Visible="False"></asp:Label>&nbsp;<asp:DropDownList ID="drdclass" runat="server" class="btn btn-primary dropdown-toggle" Visible="False">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="color: #FFFFFF; width: 162px;">
                                                <asp:Label ID="lblmkcu" runat="server" Text="Mật khẩu cũ" Visible="False"></asp:Label></td>
                                            <td align="left">
                                                <asp:TextBox ID="txtmkcu" runat="server" Visible="False" class="txtinput"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="color: #FFFFFF; height: 38px; width: 162px;">
                                                <asp:Label ID="lblmkm" runat="server" Text="Mật khẩu mới" Visible="False"></asp:Label></td>
                                            <td style="height: 38px" align="left">
                                                <asp:TextBox ID="txtmkm" runat="server" Visible="False" class="txtinput"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 162px">
                                                <asp:Label ID="lblthongbao" runat="server" Visible="False" ForeColor="Red"></asp:Label>
                                                <asp:Button ID="btnhuy" runat="server" Text="Hủy" Visible="False" OnClick="btnhuy_Click" class="w3-button w3-indigo" />
                                                &nbsp;<asp:Button ID="btnluu" runat="server" Text="Lưu" Visible="False" class="w3-button w3-green" OnClick="btnluu_Click" /></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div id="menu1" class="tab-pane fade">
                <div class="w3-row w3-margin">
                    <div class="w3-col s3 w3-left">
                        <table>
                            <tr>
                                <td align="center" class="modal-sm" style="color: #FFFFFF; width: 281px;">
                                    <img src="img/rank/0.png" style="width: 205px; height: 140px" />
                                </td>
                                <td rowspan="4" style="width: 5px">&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" class="modal-sm" style="color: #FFFFFF; width: 281px;">
                                    <asp:Label ID="Label6" runat="server" Text="Chưa có hang"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="modal-sm" style="color: #FFFFFF; width: 281px; height: 64px;">
                                    <asp:Label ID="Label2" runat="server" Text="Số điểm"></asp:Label>
                                    <br />
                                    <div class="progress">
                                        <div aria-valuemax="100" aria-valuemin="0" aria-valuenow="0" class="progress-bar progress-bar-striped active" role="progressbar" style="width: 100%">
                                            100% ĐKN
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="modal-sm" style="color: #FFFFFF; width: 281px;">
                                    <asp:Label ID="Label7" runat="server" Text="Chiến thắng"></asp:Label>
                                    &nbsp;<asp:Label ID="Label8" runat="server" Text="100"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div class="w3-col s9 w3-right">
                        <table class="scroll w3-table-all w3-hoverable" width="100%">
                            <thead>
                                <tr class="w3-light" style="text-align: center; color: white; background-color: #8bc34a !important;">
                                    <th class="col-xs-1" align="center">No.</th>
                                    <th class="col-xs-3" align="center">Tên</th>
                                    <th class="col-xs-2" align="center">Level</th>
                                    <th class="col-xs-2" align="center">Lớp</th>
                                    <th class="col-xs-2" align="center">War</th>
                                    <th class="col-xs-2" align="center">Điểm</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class="col-xs-1" align="center">1</td>
                                    <td class="col-xs-3">&nbsp;Lê Thành Đạt</td>
                                    <td class="col-xs-2" align="center">13</td>
                                    <td class="col-xs-2" align="center">10B2</td>
                                    <td class="col-xs-2" align="center">&nbsp;120</td>
                                    <td class="col-xs-2" align="center">&nbsp;780</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">2</td>
                                    <td class="col-xs-3">&nbsp;Lê Văn Tài</td>
                                    <td class="col-xs-2" align="center">10</td>
                                    <td class="col-xs-2" align="center">10A1</td>
                                    <td class="col-xs-2" align="center">&nbsp;89</td>
                                    <td class="col-xs-2" align="center">&nbsp;600</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">3</td>
                                    <td class="col-xs-3">&nbsp;Nguyễn Hữu Thắng</td>
                                    <td class="col-xs-2" align="center">11</td>
                                    <td class="col-xs-2" align="center">10B1</td>
                                    <td class="col-xs-2" align="center">&nbsp;67</td>
                                    <td class="col-xs-2" align="center">&nbsp;590</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">4</td>
                                    <td class="col-xs-3">&nbsp;Phạm Minh Đạt</td>
                                    <td class="col-xs-2" align="center">9</td>
                                    <td class="col-xs-2" align="center">10B2</td>
                                    <td class="col-xs-2" align="center">&nbsp;65</td>
                                    <td class="col-xs-2" align="center">&nbsp;578</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">5</td>
                                    <td class="col-xs-3">&nbsp;Trần văn cường</td>
                                    <td class="col-xs-2" align="center">7</td>
                                    <td class="col-xs-2" align="center">10A2</td>
                                    <td class="col-xs-2" align="center">&nbsp;64</td>
                                    <td class="col-xs-2" align="center">&nbsp;560</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">6</td>
                                    <td class="col-xs-3">&nbsp;Lê Tuyết Nhi</td>
                                    <td class="col-xs-2" align="center">13</td>
                                    <td class="col-xs-2" align="center">10A1</td>
                                    <td class="col-xs-2" align="center">&nbsp;63</td>
                                    <td class="col-xs-2" align="center">&nbsp;500</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">7</td>
                                    <td class="col-xs-3">&nbsp;Chu Mạnh An</td>
                                    <td class="col-xs-2" align="center">10</td>
                                    <td class="col-xs-2" align="center">10B3</td>
                                    <td class="col-xs-2" align="center">&nbsp;62</td>
                                    <td class="col-xs-2" align="center">&nbsp;450</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">8</td>
                                    <td class="col-xs-3">&nbsp;Lê Thắng</td>
                                    <td class="col-xs-2" align="center">11</td>
                                    <td class="col-xs-2" align="center">10B2</td>
                                    <td class="col-xs-2" align="center">&nbsp;59</td>
                                    <td class="col-xs-2" align="center">&nbsp;400</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">9</td>
                                    <td class="col-xs-3">&nbsp;Trần văn sang</td>
                                    <td class="col-xs-2" align="center">12</td>
                                    <td class="col-xs-2" align="center">10C2</td>
                                    <td class="col-xs-2" align="center">&nbsp;55</td>
                                    <td class="col-xs-2" align="center">&nbsp;335</td>
                                </tr>
                                <tr>
                                    <td class="col-xs-1" align="center">10</td>
                                    <td class="col-xs-3">&nbsp;Nguyễn Duy Anh</td>
                                    <td class="col-xs-2" align="center">11</td>
                                    <td class="col-xs-2" align="center">10A1</td>
                                    <td class="col-xs-2" align="center">&nbsp;54</td>
                                    <td class="col-xs-2" align="center">&nbsp;320</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div id="menu2" class="tab-pane fade">
                <div class="w3-row w3-margin">
                    <div class="w3-col s12 w3-center">
                        <div class="w3-left">
                            <p>
                                <asp:Label ID="lblday" runat="server" Text="Ngày :" ForeColor="White"></asp:Label>
                                <input type="text" id="datepicker" class="txtinput">
                            </p>
                        </div>

                        <table class="scroll w3-table" width="100%">
                            <thead>
                                <tr class="w3-light" style="text-align: center; color: white; background-color: #8bc34a !important;">
                                    <th class="col-xs-1" align="center">No.</th>
                                    <th class="col-xs-3" align="center">Tên</th>
                                    <th class="col-xs-2" align="center">Level</th>
                                    <th class="col-xs-2" align="center">&nbsp;Lớp</th>
                                    <th class="col-xs-2" align="center">&nbsp;Loại</th>
                                    <th class="col-xs-2" align="center">&nbsp;Kết quả</th>
                                    <th class="col-xs-2" align="center">Điểm</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class="bg-info">
                                    <td class="col-xs-1" align="center">1</td>
                                    <td class="col-xs-3">Nguyễn Duy Anh</td>
                                    <td class="col-xs-2" align="center">17</td>
                                    <td class="col-xs-2" align="center">10B1</td>
                                    <td class="col-xs-2" align="center">Đấu đơn</td>
                                    <td class="col-xs-2" align="center">Chiến thắng</td>
                                    <td class="col-xs-2" align="center">25</td>
                                </tr>
                                <tr class="bg-info">
                                    <td class="col-xs-1" align="center">2</td>
                                    <td class="col-xs-3">Trần Văn An</td>
                                    <td class="col-xs-2" align="center">12</td>
                                    <td class="col-xs-2" align="center">10B3</td>
                                    <td class="col-xs-2" align="center">Đấu đơn</td>
                                    <td class="col-xs-2" align="center">Chiến thắng</td>
                                    <td class="col-xs-2" align="center">0.75</td>
                                </tr>
                                <tr class="bg-info">
                                    <td class="col-xs-1" align="center">3</td>
                                    <td class="col-xs-3">Lê Viết Dũng</td>
                                    <td class="col-xs-2" align="center">15</td>
                                    <td class="col-xs-2" align="center">10B1</td>
                                    <td class="col-xs-2" align="center">Đấu đơn</td>
                                    <td class="col-xs-2" align="center">Chiến thắng</td>
                                    <td class="col-xs-2" align="center">1</td>
                                </tr>
                                <tr class="bg-danger">
                                    <td class="col-xs-1" align="center">4</td>
                                    <td class="col-xs-3">Lê Thu Thảo</td>
                                    <td class="col-xs-2" align="center">21</td>
                                    <td class="col-xs-2" align="center">10A1</td>
                                    <td class="col-xs-2" align="center">Đấu đơn</td>
                                    <td class="col-xs-2" align="center">Thất bại</td>
                                    <td class="col-xs-2" align="center">0</td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div id="menu3" class="tab-pane fade">
                <h3>Shop tướng</h3>
                <p>
                    Đang cập nhật
                </p>
            </div>
            <div id="menu4" class="tab-pane fade">
                <h3>Shop Pet</h3>
                <p>
                    Đang cập nhật
                </p>
            </div>
        </div>
        <br />
    </div>
    <div class="w3-center">
        <img src="img/Kindred.png" class="kindred" />
    </div>
    <!-- End Tab menu tướng-->
    <div class="line">
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <!-- Button môn học-->
            <div class="w3-row">
                <div class="w3-col m2 w3-center">
                    <div class="w3-tag w3-round w3-green" style="padding: 3px">
                        <asp:Button ID="btntoan" runat="server" Text="Toán"
                            class="btn w3-tag w3-round w3-green w3-border w3-border-white" OnClick="btntoan_Click" />
                    </div>
                </div>
                <div class="w3-col m2 w3-center">
                    <div class="w3-tag w3-round w3-teal" style="padding: 3px">
                        <asp:Button ID="btnly" runat="server" Text="Lý" class="btn w3-tag w3-round w3-teal w3-border w3-border-white" OnClick="btnly_Click" />
                    </div>
                </div>
                <div class="w3-col m2 w3-center">
                    <div class="w3-tag w3-round w3-indigo" style="padding: 3px">
                        <asp:Button ID="btnhoa" runat="server" Text="Hóa"
                            class="btn w3-tag w3-round w3-indigo w3-border w3-border-white" OnClick="btnhoa_Click" />
                    </div>
                </div>
                <div class="w3-col m2 w3-center">
                    <div class="w3-tag w3-round w3-red" style="padding: 3px">
                        <asp:Button ID="btntin" runat="server" Text="Tin"
                            class="btn w3-tag w3-round w3-red w3-border w3-border-white" OnClick="btntin_Click" />
                    </div>
                </div>
            </div>
            <!-- End button môn học-->
            <div class="line">
            </div>
            <!-- button chọn-->
            <div class="w3-row">
                <div class="w3-col s3 w3-center">
                    <asp:Button ID="btndanhnor" class="btn btn-primary loading" data-toggle="tooltip" runat="server" title="Đánh máy để lấy điểm kinh nghiệm và điểm thưởng!" Text="Đánh Máy"  OnClick="btndanhnor_Click" Visible="False" />
                </div>
                <div class="w3-col s3 w3-center">
                    <asp:Button ID="btndanhdon" runat="server" data-toggle="tooltip" title="Đánh đơn để lấy điểm xếp hạng và điểm thưởng!" Text="Đánh đơn" class="btn btn-warning loading" Visible="false" OnClick="btndanhdon_Click" />
                </div>
                <div class="w3-col s3 w3-center">
                    <asp:Button ID="btnxephang" runat="server" Text="Xếp Hạng" data-toggle="tooltip" title="Đánh xếp hạng để lấy điểm xếp hạng và nhiều phần quà hấp dẫn!" class="btn btn-danger loading" Visible="False" OnClick="btnxephang_Click" />
                </div>
                <div class="w3-col s3 w3-center">
                    <asp:Button ID="btnevent" runat="server" Text="Event" data-toggle="tooltip" title="Event chỉ diễn ra khi có sự kiện đặc biệt với nhiều phần quà quý!" class="btn btn-success loading" OnClick="btnevent_Click" Visible="False"/>
                </div>
            </div>
            <script>
                $(document).ready(function () {
                    $('[data-toggle="tooltip"]').tooltip();
                });
            </script>
            <!-- end button chọn-->
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
