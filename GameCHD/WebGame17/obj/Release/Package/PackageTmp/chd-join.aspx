<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="chd-join.aspx.cs" Inherits="ChDGame.chd_join" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgs" style="height: initial;">
        <script>
            var time = new Date().getTime();
            $(document.body).bind("mousemove keypress", function (e) {
                time = new Date().getTime();
            });

            function refresh() {
                if (new Date().getTime() - time >= 5000)
                    window.location.reload(true);
                else
                    setTimeout(refresh, 10000);
            }

            setTimeout(refresh, 10000);
        </script>
        <script type="text/javascript">
            function openModal() {
                $('#modalSignUp').modal({ show: true });
            }
        </script>
        <div id="modalSignUp" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">
                            <p style="color: blue">Admin thông báo:</p>
                        </h4>
                    </div>
                    <div class="modal-body">
                        <p>
                            <asp:Label ID="lbltbao" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Khối 10</a></li>
            <li><a data-toggle="tab" href="#menu1">Khối 11</a></li>
            <li><a data-toggle="tab" href="#menu2">Khối 12</a></li>
        </ul>
            <div class="tab-content">
                <div id="home" class="tab-pane fade in active">
                    <asp:Repeater ID="Rptkhoi10" runat="server" OnItemDataBound="RptPhan_ItemDataBound">
                        <ItemTemplate>
                            <div class="row">
                                <div class="row  w3-margin">
                                    <span class="label label-success">
                                        <asp:HiddenField ID="hdfIDphan" runat="server" Value='<%#Eval("IDPhan")%>' />
                                        <asp:Label ID="lblnamePhan" runat="server" Text='<%#Eval("NamePhan") %>'></asp:Label></span>
                                </div>
                                <asp:Repeater ID="RptRoom" runat="server" OnItemCommand="RptRoom_ItemCommand">
                                    <ItemTemplate>
                                        <div class="item w3-margin">
                                            <asp:Button ID="btnJoin" CssClass="imgjoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CommandName="Join" CommandArgument='<%#Eval("IDChuong") %>' />
                                            <span class="caption"><a style="color: white">
                                                <asp:HiddenField ID="HfIDPhan" runat="server" Value='<%#Eval("IDPhan") %>' />
                                                <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameChuong") %>'></asp:Label></a></span>
                                            <asp:HiddenField ID="HdNote" runat="server" Value='<%#Eval("Note") %>' />
                                            <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div id="menu1" class="tab-pane fade">
                    <asp:Repeater ID="rptkhoi11" runat="server" OnItemDataBound="RptPhan_ItemDataBound">
                        <ItemTemplate>
                            <div class="row">
                                <div class="row  w3-margin">
                                    <span class="label label-success">
                                        <asp:HiddenField ID="hdfIDphan" runat="server" Value='<%#Eval("IDPhan")%>' />
                                        <asp:Label ID="lblnamePhan" runat="server" Text='<%#Eval("NamePhan") %>'></asp:Label></span>
                                </div>
                                <asp:Repeater ID="RptRoom" runat="server" OnItemCommand="RptRoom_ItemCommand">
                                    <ItemTemplate>
                                        <div class="item w3-margin">
                                            <asp:Button ID="btnJoin" CssClass="imgjoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CommandName="Join" CommandArgument='<%#Eval("IDChuong") %>' />
                                            <span class="caption"><a style="color: white">
                                                <asp:HiddenField ID="HfIDPhan" runat="server" Value='<%#Eval("IDPhan") %>' />
                                                <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameChuong") %>'></asp:Label></a></span>
                                            <asp:HiddenField ID="HdNote" runat="server" Value='<%#Eval("Note") %>' />
                                            <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div id="menu2" class="tab-pane fade">
                    <asp:Repeater ID="RptPhan" runat="server" OnItemDataBound="RptPhan_ItemDataBound">
                        <ItemTemplate>
                            <div class="row">
                                <div class="row  w3-margin">
                                    <span class="label label-success">
                                        <asp:HiddenField ID="hdfIDphan" runat="server" Value='<%#Eval("IDPhan")%>' />
                                        <asp:Label ID="lblnamePhan" runat="server" Text='<%#Eval("NamePhan") %>'></asp:Label></span>
                                </div>
                                <asp:Repeater ID="RptRoom" runat="server" OnItemCommand="RptRoom_ItemCommand">
                                    <ItemTemplate>
                                        <div class="item w3-margin">
                                            <asp:Button ID="btnJoin" CssClass="imgjoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CommandName="Join" CommandArgument='<%#Eval("IDChuong") %>' />
                                            <span class="caption"><a style="color: white">
                                                <asp:HiddenField ID="HfIDPhan" runat="server" Value='<%#Eval("IDPhan") %>' />
                                                <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameChuong") %>'></asp:Label></a></span>
                                            <asp:HiddenField ID="HdNote" runat="server" Value='<%#Eval("Note") %>' />
                                            <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
    </div>
</asp:Content>
