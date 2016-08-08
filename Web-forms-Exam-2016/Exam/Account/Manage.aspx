<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="PlaylistSystem.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView
        runat="server" ID="lvProfile"
        SelectMethod="lvProfile_GetData"
        ItemType="PlaylistSystem.Models.User"
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
            <div>
                <img src="<%# Item.ProfilePhotoUrl %>" alt="avatar" />

            </div>
            <div>
                <p>
                    <label>Email</label>
                <%# Item.Email %>

                </p>
                <p>
                    <label>Firrst name</label>
                    <input type="text" placeholder="<%# Item.FirstName %>" />
                </p>
                <p>

                    <label>last name</label>
                    <input type="text" placeholder="<%# Item.LastName %>" />
                </p>
                <p>
                    <label>image</label>
                    <input type="text" placeholder="<%# Item.ProfilePhotoUrl %>" />
                </p>
                <p>
                    <label>facebook</label>
                    <input type="text" placeholder="<%# Item.FacebookProfile %>" />

                </p>
                <p>
                    <label>youtube</label>
                    <input type="text" placeholder="<%# Item.YoutubeProfile %>" />

                </p>
            </div>
            <div>
                <asp:ListView
                    runat="server"
                    ID="ListView1"
                    SelectMethod="ListView1_GetData"
                    ItemType="PlaylistSystem.Models.Playlist">
                    <LayoutTemplate>
                        <ul class="col-md-4">
                            <li runat="server" id="itemPlaceholder"></li>
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <a href="/ViewPlaylistDetails.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <p>No videos.</p>
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>

        </ItemTemplate>
    </asp:ListView>

</asp:Content>
