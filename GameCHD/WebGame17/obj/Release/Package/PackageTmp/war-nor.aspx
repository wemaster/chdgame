<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="war-nor.aspx.cs" Inherits="ChDGame.war_nor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg">
        <div style="height: 277px; overflow-x: auto;">
            <div class="w3-cell-row">
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
                                    <td align="center">
                                        <asp:Image ID="Image3" runat="server" ImageUrl="~/img/level/lv.png" />
                                        <img src="img/level/<%#Eval("LevelAcc") %>.png" />
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
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
                                    <td align="center">
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
                <!-- Acc right-->
                <div class="w3-container w3-cell w3-right w3-animate-top">
                    <asp:Repeater ID="RptAcc2" runat="server">
                        <ItemTemplate>
                            <table style="width: 300px;">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td rowspan="3">
                                        <img src="img/boss/<%#Eval("imgBoss") %>.png" height="260px" width="316px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="auto-style1">
                                        <div class="monster2" style="background-image: url('img/pet/<%#Eval("imgpet")%>.png')"></div>
                                        <style>
                                            .monster2 {
                                                width: 73px;
                                                height: 81px;
                                                animation: play 0.8s steps(4) infinite;
                                            }
                                        </style>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center"></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <!-- end acc right-->
            </div>
            <!--Coundown-->
        </div>

    </div>
    <div class="row canh">
        <div class="w3-container w3-twothird">
            <section id="wizard">
                <div id="rootwizard">
                    <div class="panell panel-success">
                        <div class="panel-heading">
                            <div class="navbar">
                                <div class="navbar-inner">
                                    <div class="container">
                                        <ul>
                                            <li><a href="#tab1" data-toggle="tab">Câu 1</a></li>
                                            <li><a href="#tab2" data-toggle="tab">Câu 2</a></li>
                                            <li><a href="#tab3" data-toggle="tab">Câu 3</a></li>
                                            <li><a href="#tab4" data-toggle="tab">Câu 4</a></li>
                                            <li><a href="#tab5" data-toggle="tab">Câu 5</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div id="bar" class="progress">
                                <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                            </div>
                        </div>
                        <div class="tab-content">
                            <asp:Repeater ID="RptTest" runat="server">
                                <ItemTemplate>
                                    <div class="tab-pane" id="tab<%# Container.ItemIndex + 1 %>">
                                        <div class="panell panel-success">
                                            <div class="panel-heading">
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("TestContent")%>'></asp:Label>
                                            </div>
                                            <div class="panel-body">
                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                    <ContentTemplate>
                                                        <script type="text/javascript">
                                                            $(document).ready(function () {
                                                                $("#Groupcheck0 input:checkbox").on('change', function () {
                                                                    $("#Groupcheck0 input:checkbox").not(this).prop('checked', false);
                                                                });
                                                            });
                                                        </script>
                                                        <script type="text/javascript">
                                                            $(document).ready(function () {
                                                                $("#Groupcheck1 input:checkbox").on('change', function () {
                                                                    $("#Groupcheck1 input:checkbox").not(this).prop('checked', false);
                                                                });
                                                            });

                                                        </script>
                                                        <script type="text/javascript">
                                                            $(document).ready(function () {
                                                                $("#Groupcheck2 input:checkbox").on('change', function () {
                                                                    $("#Groupcheck2 input:checkbox").not(this).prop('checked', false);
                                                                });
                                                            });

                                                        </script>
                                                        <script type="text/javascript">
                                                            $(document).ready(function () {
                                                                $("#Groupcheck3 input:checkbox").on('change', function () {
                                                                    $("#Groupcheck3 input:checkbox").not(this).prop('checked', false);
                                                                });
                                                            });

                                                        </script>
                                                        <script type="text/javascript">
                                                            $(document).ready(function () {
                                                                $("#Groupcheck4 input:checkbox").on('change', function () {
                                                                    $("#Groupcheck4 input:checkbox").not(this).prop('checked', false);
                                                                });
                                                            });

                                                        </script>
                                                        <div id="Groupcheck<%#DataBinder.Eval(Container, "ItemIndex", "")%>">
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
                                                        </div>
                                                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("TestCorrect")%>' />

                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </section>
            <div class="w3-container">
                <div class="w3-panel w3-padding-32 w3-center w3-animate-opacity" style="line-height:1.8">
                    <asp:Label ID="lblthongbao" runat="server" Text="" Visible="False" class="demotext"></asp:Label>
                </div>
            </div>
            <script>
                $(document).ready(function () {
                    $('#rootwizard').bootstrapWizard({
                        onTabShow: function (tab, navigation, index) {
                            var $total = navigation.find('li').length;
                            var $current = index + 1;
                            var $percent = ($current / $total) * 100;
                            $('#rootwizard .progress-bar').css({ width: $percent + '%' });
                        }
                    });
                    window.prettyPrint && prettyPrint()
                });
            </script>
        </div>
        <div class="w3-container w3-third">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="panell panel-success">
                        <div class="panel-heading">Kết quả</div>
                        <div class="panel-body">
                            <asp:Repeater ID="rptchecktrue" runat="server">
                                <ItemTemplate>
                                    <img src="img/<%#Eval("kotae") %>.png" class="imags w3-animate-opacity" />
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                    <div class="panell panel-success">
                        <div class="panel-heading">Thời gian</div>
                        <div class="panel-body">
                            <asp:Label ID="myform" runat="server" ClientIDMode="Static" ForeColor="Red" Font-Size="Larger" Font-Bold="True"></asp:Label>
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
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="btnfinish" class="btn btn-primary loading" runat="server" Text="Finish" OnClick="btnfinish_Click" />
        </div>
    </div>
</asp:Content>
