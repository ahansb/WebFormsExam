//namespace PlaylistSystem.Controls
//{
//    using Services.Contracts;
//    using Ninject;
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Web;
//    using System.Web.UI;
//    using System.Web.UI.WebControls;
//    using Microsoft.AspNet.Identity;
//    using PlaylistSystem.Services;
//    using Models;
//    using Data.Repositories;
//    using Data;

//    public partial class LikeHateControl : System.Web.UI.UserControl
//    {
//        public ILikesServices LikesServices { get; set; } = new LikesServices(new GenericRepository<Rating>(new PlaylistSystemDbContext()));

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            var articleIdAsString = this.Request.QueryString["id"];

//            // TODO: validaiton

//            var userId = Page.User.Identity.GetUserId();

//            var likeSoFar = this.LikesServices.GetByAuthorAndArticle(userId, int.Parse(articleIdAsString));

//            if (likeSoFar == null)
//            {
//                return;
//            }

//            if (likeSoFar.Value!=null)
//            {
//                this.btnLike.Visible = false;
//            }
//            else
//            {
//                this.btnHate.Visible = false;
//            }
//        }

//        protected void Page_PreRender(object sender, EventArgs e)
//        {
            
//        }

//        protected void btnLike_Click(object sender, EventArgs e)
//        {
//            var articleIdAsString = this.Request.QueryString["id"];

//            // TODO: validation

//            var newLike = new Rating()
//            {
//                Value = true,
//                PlaylistId = int.Parse(articleIdAsString),
//                UserId = Page.User.Identity.GetUserId()
//            };

//            this.LikesServices.Create(newLike);
//        }

//        protected void btnHate_Click(object sender, EventArgs e)
//        {
//            var articleIdAsString = this.Request.QueryString["id"];

//            // TODO: validation

//            var newLike = new Rating()
//            {
//                Value = false,
//                PlaylistId = int.Parse(articleIdAsString),
//                UserId = Page.User.Identity.GetUserId()
//            };

//            this.LikesServices.Create(newLike);
//        }
//    }
//}