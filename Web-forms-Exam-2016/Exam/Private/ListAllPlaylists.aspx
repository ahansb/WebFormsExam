<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListAllPlaylists.aspx.cs" Inherits="PlaylistSystem.Private.ListAllPlaylists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="lvPlaylists" runat="server"
                  DataKeyNames="Id"
                  ItemType="PlaylistSystem.Models.Playlist"
                  SelectMethod="lvPlaylists_GetData"
                  DeleteMethod="lvPlaylists_DeleteItem"
                  UpdateMethod="lvPlaylists_UpdateItem"
                  InsertMethod="lvPlaylists_InsertItem"
                  InsertItemPosition="None">
        <LayoutTemplate>
            <p>
                Ascending
                <asp:HyperLink NavigateUrl="?orderBy=Title&sortDirection=Ascending" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
                <asp:HyperLink NavigateUrl="?orderBy=DateCreated&sortDirection=Ascending" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
                <asp:HyperLink NavigateUrl="?orderBy=Rating&sortDirection=Ascending" Text="Sort by Rating" runat="server" CssClass="btn btn-md-2 btn-default" />
            </p>
            <p>
                Descending
                <asp:HyperLink NavigateUrl="?orderBy=Title&sortDirection=Descending" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
                <asp:HyperLink NavigateUrl="?orderBy=DateCreated&sortDirection=Descending" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
                <asp:HyperLink NavigateUrl="?orderBy=Rating&sortDirection=Descending" Text="Sort by Rating" runat="server" CssClass="btn btn-md-2 btn-default" />
            </p>
            <table>
                <thead>
                    <th>Title</th>
                    <th>Category</th>
                    <th>Creator</th>
                    <th>Number of videos</th>
                </thead>
                <tbody>

                    <div id="itemPlaceholder" runat="server"></div>

                </tbody>
            </table>

            <br />
            <br />
            <asp:DataPager runat="server" PageSize="10">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>

            <asp:Button Text="Insert new playlist" runat="server" OnClick="Unnamed_Click" CssClass="btn btn-info pull-right" />
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Title %></td>
                <td><%# Item.Category.Name %></td>
                <td><%# Item.Creator.UserName %></td>
                <td><%# Item.Videos.Count %></td>
            </tr>

        </ItemTemplate>
    </asp:ListView>

</asp:Content>
