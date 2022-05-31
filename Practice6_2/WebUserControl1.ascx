<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Practice6_2.WebUserControl1" %>
<br />
<asp:Button ID="OpenCust" runat="server" OnClick="OpenCust_Click" Text="Открыть заказчиков" />
<br />
<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
<br />
<asp:Button ID="Kesh" runat="server" OnClick="Kesh_Click" Text="Кэш" />
<p>
    <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
    </asp:GridView>
</p>
<p>
    <asp:Label ID="CacheMsg" runat="server"></asp:Label>
</p>


