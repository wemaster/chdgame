<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="chd-event.aspx.cs" Inherits="WebGame17.chd_event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <script type="text/javascript">
                function openModal() {
                    $('#modalSignUp').modal({ show: true });
                }
            </script>
            <div id="modalSignUp" class="modal fade">
                <div class="modal-dialog modal-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <asp:Button ID="btnclose" class="close" data-dismiss="modal" aria-hidden="true" runat="server" Text="&times;" PostBackUrl="~/chd-event.aspx" />
                            <h4 class="modal-title">
                                <asp:Panel ID="Panel1" runat="server" Visible="False">
                                    <p style="color: blue">
                                        Hãy chiến thắng để nhận nhiều
                                        <img src="img/huanchuong/7e2dedce_md.gif" />
                                        ở màn tiếp theo!
                                    </p>
                                </asp:Panel>
                                <asp:Label ID="lbladmin" runat="server" Visible="False"></asp:Label>
                            </h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblketqua" runat="server" Text=""></asp:Label><asp:Image ID="Image1" runat="server" Visible="False" ImageUrl="~/img/gold/Ph03nyx-Super-Mario-Question-Coin.png" Width="30px" />
                            <asp:Panel ID="Panel2" runat="server">
                                <div class="w3-container w3-twothird">
                                    <div class="panel panel-primary">
                                        <asp:Repeater ID="RptTest" runat="server">
                                            <ItemTemplate>
                                                <div class="panel-heading">
                                                    Câu hỏi :<asp:Label ID="lbltest" runat="server" Text='<%#Eval("TestContent")%>' ForeColor="White"></asp:Label>
                                                </div>
                                                <div class="panel-body">
                                                    <script type="text/javascript">
                                                        $(document).ready(function () {
                                                            $(".w3-ul input:checkbox").on('change', function () {
                                                                $(".w3-ul input:checkbox").not(this).prop('checked', false);
                                                            });
                                                        });
                                                    </script>
                                                    <ul class="w3-ul">
                                                        <li>
                                                            <asp:CheckBox ID="ckcA" Text='<%#Eval("TestA") %>' runat="server" Class="test"></asp:CheckBox>
                                                        </li>
                                                        <li>
                                                            <asp:CheckBox ID="ckcB" Text='<%#Eval("TestB") %>' runat="server" Class="test"></asp:CheckBox>
                                                        </li>
                                                        <li>
                                                            <asp:CheckBox ID="ckcC" Text='<%#Eval("TestC") %>' runat="server" Class="test"></asp:CheckBox>
                                                        </li>
                                                        <li>
                                                            <asp:CheckBox ID="ckcD" Text='<%#Eval("TestD") %>' runat="server" Class="test"></asp:CheckBox>
                                                        </li>
                                                    </ul>
                                                    <asp:HiddenField ID="hdflbl" Value='<%#Eval("TestCorrect")%>' runat="server" />
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                                <div class="w3-container w3-third">
                                    <div class="panell panel-success">
                                        <div class="panel-heading">Thời gian</div>
                                        <div class="panel-body">
                                            <asp:Label ID="myform" runat="server" ClientIDMode="Static" ForeColor="Red" Font-Size="Larger" Font-Bold="True" Visible="False"></asp:Label>
                                            <script type="text/javascript" language="javascript">
                                                function Func() {
                                                    window.stop();
                                                }
                                            </script>
                                            <script>
                                                if (sessionStorage.getItem("total_seconds")) {
                                                    var total_seconds = sessionStorage.getItem("total_seconds");
                                                } else {
                                                    var total_seconds = 120 * 1;

                                                }
                                                var minutes = parseInt(total_seconds / 60);
                                                var seconds = parseInt(total_seconds % 60);
                                                function clearCountdown() {
                                                    sessionStorage.removeItem("total_seconds")
                                                }
                                                window.onunload = clearCountdown();
                                                function countDownTimer() {
                                                    if (seconds < 10) {
                                                        seconds = "0" + seconds;
                                                    } if (minutes < 10) {
                                                        minutes = "0" + minutes;
                                                    }

                                                    document.getElementById('<%=myform.ClientID %>').innerHTML = minutes + " : " + seconds;
                                            if (total_seconds <= 0) {
                                                clearCountdown();
                                                setTimeout("document.myform.submit()", 1);
                                                document.getElementById('<%= btnfinish.ClientID %>').click();
                                        //window.location = "mem-login.aspx";

                                    } else {
                                        total_seconds = total_seconds - 1;
                                        minutes = parseInt(total_seconds / 60);
                                        seconds = parseInt(total_seconds % 60);
                                        sessionStorage.setItem("total_seconds", total_seconds)
                                        setTimeout("countDownTimer()", 1000);
                                    }
                                }
                                setTimeout("countDownTimer()", 1000);
                                            </script>
                                        </div>
                                    </div>
                                    <asp:Button ID="btnfinish" class="btn btn-primary loading" runat="server" Text="Finish" OnClick="btnfinish_Click" />
                                </div>
                            </asp:Panel>
                        </div>
                        <div class="modal-footer">
                        </div>
                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
            <!-- /.modal -->

            <div class="w3-row map">
                <div id='thediv1'>
                    <asp:ImageButton ID="Imbtcau1" CssClass="thediv1" runat="server" OnClick="Imbtcau1_Click" ImageUrl="~/img/Ball.gif" />
                    <asp:Image ID="imgcau1dis" runat="server" CssClass="thediv1dis" ImageUrl="~/img/Balldis.png" />
                </div>
                <div id='thediv2'>
                    <asp:ImageButton ID="ImageBtcau2" CssClass="thediv2" runat="server" ImageUrl="~/img/Ball.gif" OnClick="ImageBtcau2_Click" Visible="False" />
                    <asp:Image ID="imgcau2dis" runat="server" CssClass="thediv2dis" ImageUrl="~/img/Balldis.png" />
                </div>
                <div id='thediv3'>
                    <asp:ImageButton ID="ImgBTcau3" CssClass="thediv3" runat="server" ImageUrl="~/img/Ball.gif" OnClick="ImgBTcau3_Click" Visible="False" />
                    <asp:Image ID="imgcau3dis" runat="server" CssClass="thediv3dis" ImageUrl="~/img/Balldis.png" />
                </div>
                <div id='thediv4'>
                    <asp:ImageButton ID="Imcau4" CssClass="thediv4" runat="server" ImageUrl="~/img/Ball.gif" OnClick="Imcau4_Click" Visible="False" />
                    <asp:Image ID="Img4dis" runat="server" CssClass="thediv4dis" ImageUrl="~/img/Balldis.png" />
                </div>
                <div id='thediv5'>
                    <asp:ImageButton ID="Imgcau5" CssClass="thediv5" runat="server" ImageUrl="~/img/Ball.gif" OnClick="Imgcau5_Click" Visible="False" />
                    <asp:Image ID="Igcau5dis" runat="server" CssClass="thediv5dis" ImageUrl="~/img/Balldis.png" />
                </div>
                <div id='thediv6' class="img-circle">
                    <asp:ImageButton ID="Imgcau6" CssClass="thediv6 img-circle" runat="server" ImageUrl="~/img/div6.gif" OnClick="Imgcau6_Click" Visible="False" />
                    <asp:Image ID="Igcau6dis" runat="server" CssClass="thediv6dis" ImageUrl="~/img/Balldis.png" />
                </div>
            </div>
 
</asp:Content>
