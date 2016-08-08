<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlaylistDetails.aspx.cs" Inherits="PlaylistSystem.ViewPlaylistDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView
        runat="server" ID="fvPlaylist"
        SelectMethod="fvPlaylist_GetItem"
        ItemType="PlaylistSystem.Models.Playlist"
        DataKeyNames="Id">
        <LayoutTemplate>

            <div runat="server" id="itemPlaceholder"></div>
            <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <h2><%#: Item.Title %></h2>
                            <p>Rating : <%#  Item.Ratings.Count != 0?Item.Ratings.Average(r=>r.Value):0 %></p>
                            <p>
                                Description: <%#: Item.Description %>
                            </p>
                            <p>
                                Category: <%# Item.Category.Name %>
                            </p>
                            <p>
                                <span>Author: <%#: Item.Creator.UserName %> - <%# Item.Creator.FirstName %> <%# Item.Creator.LastName %> </span>

                                <span class="pull-right"> on : <%# Item.DateCreated %></span>
                            </p>
                            <asp:ListView
                                runat="server"
                                ID="lvVideosForPlaylist"
                                DataSource="<%# Item.Videos %>"
                                ItemType="PlaylistSystem.Models.Video">
                                <LayoutTemplate>
                                    <ul class="col-md-4">
                                        <li runat="server" id="itemPlaceholder"></li>
                                    </ul>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <li>
                                        <a href="<%# Item.URL %>"><%# Item.URL %></a>
                                    </li>
                                </ItemTemplate>
                                <EmptyDataTemplate>
                                    <p>No videos.</p>
                                </EmptyDataTemplate>
                            </asp:ListView>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
