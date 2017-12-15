<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="war-room.aspx.cs" Inherits="ChDGame.war_room" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg">
        <div style="height: 301px; overflow-x: auto;">
            <!-- Labeltenacc1 và LlbTenAcc2 Hiển thị tên 2 người chơi -->
            <div class="col-sm-12 w3-center">
                <!--Acc left-->
                <asp:Repeater runat="server" ID="RptAcc1">
                    <ItemTemplate>
                        <!-- Acc Left-->
                        <div class="w3-container w3-left w3-cell w3-animate-opacity">
                            <table style="width: 300px;">
                                <tr>
                                    <td class="w3-center">
                                        <asp:Label ID="lbll" runat="server" Text="Lớp : " ForeColor="White"></asp:Label>
                                        <asp:Label ID="lblclass" runat="server" ForeColor="White" Text='<%#Eval("NameClass") %>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td></td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td rowspan="2">
                                        <div class="parent">
                                            <img src="img/vong/<%#Eval("IDVong")%>.gif" class="imge2" />
                                            <img src="img/<%#Eval("ImgChamp") %>" class="imge" height="244px" width="306px" />
                                        </div>
                                    </td>
                                    <td class="w3-center">
                                        <asp:Image ID="Image3" runat="server" ImageUrl="~/img/level/lv.png" />
                                        <img src="img/level/<%#Eval("LevelAcc") %>.png" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="w3-center">
                                        <div class="monster"></div>
                                        <style>
                                            .monster {
                                                width: 73px;
                                                height: 100px;
                                                background: url('/img/pet/<%#Eval("IDPet")%>.png') left center;
                                                animation: play 0.8s steps(4) infinite;
                                            }
                                        </style>
                                        <img src="img/rank/<%#Eval("ImgRank") %>" width="123px" height="100px" />
                                    </td>
                                    <td>
                                        <asp:Image ID="ImgeVS" runat="server" Height="103px" ImageUrl="~/img/1.png" Width="100px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="w3-center">
                                        <asp:Label ID="lblNameAcc" runat="server" ForeColor="White" Text='<%#Eval("NameAcc") %>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </div>
                        <!-- End Acc Left-->
                    </ItemTemplate>
                </asp:Repeater>
                <!--End Acc left-->
                <!--Acc right-->
                <!-- Acc right-->
                <div class="w3-container w3-cell w3-right">
                    <asp:Repeater ID="RptAcc2" runat="server">
                        <ItemTemplate>
                            <table style="width: 300px;">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td class="w3-center">
                                        <h1>
                                            <asp:Label ID="lbll2" runat="server" Text="Lớp : " ForeColor="White"></asp:Label>
                                            <asp:Label ID="lblNameClass" runat="server" ForeColor="White" Text='<%#Eval("NameClass") %>'></asp:Label></h1>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td rowspan="2">
                                        <img src="img/<%#Eval("ImgChamp") %>" height="207px" width="246px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <div class="monster2" style="background-image: url('img/pet/<%#Eval("IDPet")%>.png')"></div>
                                        <style>
                                            .monster2 {
                                                width: 73px;
                                                height: 81px;
                                                animation: play 0.8s steps(4) infinite;
                                            }
                                        </style>
                                        <img src="img/rank/<%#Eval("ImgRank") %>" height="100px" width="120px" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Image ID="Image7" runat="server" ImageUrl="~/img/level/lv.png" />
                                        <img src="img/level/<%#Eval("LevelAcc") %>.png" />
                                    </td>
                                    <td>&nbsp;</td>
                                    <td align="center">
                                        <asp:Label ID="lbltenacc" runat="server" Text='<%#Eval("NameAcc") %>' ForeColor="White"></asp:Label></h1>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <!-- end acc right-->
                <!--End Acc right-->
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            // Declare a proxy to reference the hub.          

            var notifications = $.connection.notificationHub;

            // Create a function that the hub can call to broadcast messages.

            notifications.client.recieveNotification = function (TestContent, TestA, TestB, TestC, TestD, TestCorrect) {

                // Add the message to the page.                    
                $('#<%= lbltest.ClientID %>').text(TestContent);

                    $('#<%= lblA.ClientID%>').text(TestA);

                    $('#<%= lblb.ClientID%>').text(TestB);

                    $('#<%= lblc.ClientID%>').text(TestC);

                    $('#<%= lbld.ClientID%>').text(TestD);

                    $('#<%= hdflbl.ClientID%>').text(TestCorrect);
                };

            // Start the connection.

            $.connection.hub.start().done(function () {

                notifications.server.sendNotifications();

            }).fail(function (e) {

                alert(e);

            });

            //$.connection.hub.start();

        });
    </script>
    <%--   <div id="divTest" class="w3-row">
                <div class="w3-col s12 w3-green w3-center">
                    <script type="text/javascript">
                        var time = 10;
                        window.setInterval(test, 1000);

                        function test() {
                            //update time
                            time -= 1;
                            //update the div to show the time
                            $('#<%=Label1.ClientID%>').html(time);

                            //hide the div if the time is 0
                            if (time == 0) {
                                $('#Panel1').show();
                                $('#divTest').remove();
                            }
                        }
                    </script>
                          Bạn có <asp:Label ID="Label1" runat="server" ForeColor="White" Font-Size="X-Large"></asp:Label> để chuẩn bị trước khi bắt đầu. Chúc bạn may mắn.
                </div>
            </div>--%>
    <asp:Timer ID="Timer1" runat="server" Interval="3000"  Enabled="False" OnTick="Timer1_Tick"></asp:Timer>
    <!-- End count down-->
    <div class="row canh">
        <div class="w3-container w3-twothird">
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <asp:Label ID="lbltest" runat="server" Text="" ForeColor="White"></asp:Label>
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
                                <asp:CheckBox ID="ckcA" runat="server" Class="test" ForeColor="Black"></asp:CheckBox>
                                <asp:Label ID="lblA" runat="server" Text=""></asp:Label>
                            </li>
                            <li>
                                <asp:CheckBox ID="ckcB" Text="" runat="server" Class="test" ForeColor="Black"></asp:CheckBox>
                                <asp:Label ID="lblb" runat="server" Text=""></asp:Label>
                            </li>
                            <li>
                                <asp:CheckBox ID="ckcC" Text="" runat="server" Class="test" ForeColor="Black"></asp:CheckBox>
                                <asp:Label ID="lblc" runat="server" Text=""></asp:Label>
                            </li>
                            <li>
                                <asp:CheckBox ID="ckcD" Text="" runat="server" Class="test" ForeColor="Black"></asp:CheckBox>
                                <asp:Label ID="lbld" runat="server" Text=""></asp:Label>
                            </li>
                        </ul>
                        <asp:HiddenField ID="hdflbl" runat="server" />
                    </div>
                </div>
            </asp:Panel>
        </div>
        <div class="w3-container w3-third">
            <div class="panel panel-danger">
                <div class="panel-heading">Đội 1</div>
                <div class="panel-body">
                    <asp:Repeater ID="RpTDoi1" runat="server">
                        <ItemTemplate>
                            <img src="img/<%#Eval("NameResult") %>.png" class="imags w3-animate-opacity" />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="panel panel-success">
                <div class="panel-heading">Đội 2</div>
                <div class="panel-body">
                    <asp:Repeater ID="RptDoi2" runat="server">
                        <ItemTemplate>
                            <img src="img/<%#Eval("NameResult") %>.png" class="imags w3-animate-opacity" />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">Thời gian</div>
                <div class="panel-body">
                    <asp:Label ID="lblTime" runat="server" ForeColor="Red" Font-Size="Larger" Font-Bold="True"></asp:Label>
                </div>
                <asp:Button ID="btnNext" class="btn btn-primary loading" runat="server" Text="Next" OnClick="btnNext_Click" />
            </div>
            <div class="w3-container">
                <div class="w3-panel w3-padding-32 w3-center w3-animate-opacity" style="line-height: 1.8">
                    <asp:Label ID="lblthongbao" runat="server" Text="" Visible="False" class="demotext"></asp:Label>
                </div>
            </div>
            
            <script>
                if (sessionStorage.getItem("total_seconds")) {
                    var total_seconds = sessionStorage.getItem("total_seconds");
                } else {
                    var total_seconds = 1200 * 1;

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

                    document.getElementById('<%=lblTime.ClientID %>').innerHTML = minutes + " : " + seconds;
                    if (total_seconds <= 0) {
                        clearCountdown();
                        setTimeout("document.myform.submit()", 1);
                        document.getElementById('<%= btnNext.ClientID %>').click();
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
    <!--UpdateChatbox-->
    <asp:UpdatePanel ID="update" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <ContentTemplate>
            <div class="panel panel-info">
                <div class="panel-heading">Chat Box</div>
                <div class="panel-body">
                    <div id="divContainer">
                        <div id="divChat" class="chatRoom">
                            <div>
                                Chào mừng bạn <span id='spanUser'></span> đến với CHD Game
                            </div>
                            <div class="content">
                                <div id="divChatWindow" class="chatWindow">
                                </div>
                                <div id="divusers" class="users">
                                </div>
                            </div>
                            <div class="messageBar">
                                <input class="textbox" type="text" id="txtMessage" />
                                <input id="btnSendMsg" type="button" value="Send" class="submitButton" />
                            </div>
                        </div>
                        <input id="hdId" type="hidden" />
                        <input id="hdUserName" type="hidden" />
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <!--end update chatbox-->
</asp:Content>
