<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PlaylistSystem.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>News</h1>
    <asp:Repeater
        runat="server"
        ID="PlaylistRepeater"
        SelectMethod="PlaylistRepeater_GetData"
        ItemType="PlaylistSystem.Models.Playlist">
        <HeaderTemplate>
            <h2>Most popular playlists</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <h3>
                    <a href="/ViewPlaylistDetails.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a> <small><i>by <%#: Item.Creator.UserName %></i></small>
                </h3>
                <p>Rating: <%#  Item.Ratings.Count != 0?Item.Ratings.Average(r=>r.Value):0 %></p>
            </div>
        </ItemTemplate>
    </asp:Repeater>

<%--<asp:ListView
runat="server"
ID="lvCategories"
SelectMethod="lvCategories_GetData"
ItemType="PlaylistSystem.Models.Category">
<LayoutTemplate>
<h2>All categories</h2>

<div runat="server" id="itemPlaceholder"></div>
<asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
</LayoutTemplate>
<GroupTemplate>
<div class="row">
<asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
</div>
</GroupTemplate>
<ItemTemplate>
<div class="col-md-12">
<h3><%#: Item.Name %></h3>
<asp:ListView
runat="server"
ID="lvArticlesForCategory"
DataSource="<%# Item.Articles.OrderByDescending(x => x.Likes.Count()).Take(3) %>"
ItemType="PlaylistSystem.Models.Article">
<LayoutTemplate>
<ul class="col-md-4">
<li runat="server" id="itemPlaceholder"></li>
</ul>
</LayoutTemplate>
<ItemTemplate>
<li>
<a href="ViewArticle.aspx?id=<%# Item.Id %>"><strong><%#: Item.Title %></strong> <i>by <%#: Item.Author.UserName %></i></a>
</li>
</ItemTemplate>
<EmptyDataTemplate>
<p>No articles.</p>
</EmptyDataTemplate>
</asp:ListView>
</div>
</ItemTemplate>
</asp:ListView>--%>
</asp:Content>
