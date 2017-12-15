<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="join-room.aspx.cs" Inherits="ChDGame.join_room" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg" style="height: initial;">
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
                <h4 class="modal-title"><p style="color:blue">Admin thông báo:</p></h4>
              </div>
              <div class="modal-body">
                <p>
                    <asp:Label ID="lbltbao" runat="server" Text=""></asp:Label></p>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
              </div>
            </div><!-- /.modal-content -->
          </div><!-- /.modal-dialog -->
        </div><!-- /.modal -->

        <div class="container-fluid">
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#home">Khối 10</a></li>
                <li><a data-toggle="tab" href="#menu1">Khối 11</a></li>
                <li><a data-toggle="tab" href="#menu2">Khối 12</a></li>
            </ul>
        <div class="tab-content">
        <div id="home" class="tab-pane fade in active">
             <asp:Repeater ID="Rpt12" runat="server" OnItemCommand="RptRoom_ItemCommand">
                <ItemTemplate>
                    <div class="item w3-margin">
                        <asp:Button ID="btnJoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CssClass="imgjoin" CommandName="Join" CommandArgument='<%#Eval("IDRoom") %>'/>
                        <span class="caption"><a style="color:white">
                            <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameRoom") %>'></asp:Label></a></span>
                        <asp:HiddenField ID="HdFID" runat="server" Value='<%#Eval("Note") %>' />
                        <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                        <asp:HiddenField ID="HdfAcc2" Value='<%#Eval("NameAcc2") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
         </div>
         <div id="menu1" class="tab-pane fade">
            <asp:Repeater ID="Rpt11" runat="server" OnItemCommand="RptRoom_ItemCommand">
                <ItemTemplate>
                    <div class="item w3-margin">
                        <asp:Button ID="btnJoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CssClass="imgjoin" CommandName="Join" CommandArgument='<%#Eval("IDRoom") %>'/>
                        <span class="caption"><a style="color:white">
                            <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameRoom") %>'></asp:Label></a></span>
                        <asp:HiddenField ID="HdFID" runat="server" Value='<%#Eval("Note") %>' />
                        <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                        <asp:HiddenField ID="HdfAcc2" Value='<%#Eval("NameAcc2") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
         </div>
         <div id="menu2" class="tab-pane fade">
             <asp:Repeater ID="RptRoom" runat="server" OnItemCommand="RptRoom_ItemCommand">
                <ItemTemplate>
                    <div class="item w3-margin">
                        <asp:Button ID="btnJoin" CssClass="imgjoin" runat="server" Text="" data-toggle="tooltip" data-placement="top" CommandName="Join" CommandArgument='<%#Eval("IDRoom") %>'/>
                        <span class="caption"><a style="color:white">
                            <asp:Label ID="lblnameroom" runat="server" Text='<%#Eval("NameRoom") %>'></asp:Label></a></span>
                        <asp:HiddenField ID="HdFID" runat="server" Value='<%#Eval("Note") %>' />
                        <asp:HiddenField ID="HdfAcc1" Value='<%#Eval("NameAcc1") %>' runat="server" />
                        <asp:HiddenField ID="HdfAcc2" Value='<%#Eval("NameAcc2") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
         </div>
         </div>
         </div>
    </div>
</asp:Content>
