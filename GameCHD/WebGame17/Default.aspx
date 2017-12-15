<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebGame17.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgs">
     <div class="w3-row">
            <div class="w3-col s3 w3-left">
                <video width="400" controls>
                    <source src="video/demo.mp4" type="video/mp4">
                    Your browser does not support HTML5 video.
                </video>
            </div>

            <div class="w3-col s9 w3-right">
            </div>
        </div>
    </div>
    <%--<asp:Button ID="btnWarnotlogin" runat="server" Text="Vào chiến đấu" OnClientClick="document.getElementById('id01').style.display='block';JavaScript: return false;" />--%><asp:Button ID="btnwarlogin" runat="server" Text="Vào chiến đấu" OnClick="btnwarlogin_Click" Visible="False" />

</asp:Content>
