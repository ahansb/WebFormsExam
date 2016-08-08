using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using PlaylistSystem.Models;
using System.IO;
using Ninject;
using PlaylistSystem.Services.Contracts;

namespace PlaylistSystem.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        

        protected string SuccessMessage
        {
            get;
            private set;
        }



        [Inject]
        public IPlaylistService PlaylistService { get; set; }

        [Inject]
        public IUserService UserService { get; set; }

        private bool HasPassword(ApplicationUserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        public bool HasPhoneNumber { get; private set; }

        public bool TwoFactorEnabled { get; private set; }

        public bool TwoFactorBrowserRemembered { get; private set; }

        public int LoginsCount { get; set; }

        protected void Page_Load()
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();

            HasPhoneNumber = String.IsNullOrEmpty(manager.GetPhoneNumber(User.Identity.GetUserId()));

            // Enable this after setting up two-factor authentientication
            //PhoneNumber.Text = manager.GetPhoneNumber(User.Identity.GetUserId()) ?? String.Empty;

            TwoFactorEnabled = manager.GetTwoFactorEnabled(User.Identity.GetUserId());

            LoginsCount = manager.GetLogins(User.Identity.GetUserId()).Count;

            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            //if (!IsPostBack)
            //{
            //    // Determine the sections to render
            //    if (HasPassword(manager))
            //    {
            //        ChangePassword.Visible = true;
            //    }
            //    else
            //    {
            //        CreatePassword.Visible = true;
            //        ChangePassword.Visible = false;
            //    }

            //    // Render success message
            //    var message = Request.QueryString["m"];
            //    if (message != null)
            //    {
            //        // Strip the query string from action
            //        Form.Action = ResolveUrl("~/Account/Manage");

            //        SuccessMessage =
            //            message == "ChangePwdSuccess" ? "Your password has been changed."
            //            : message == "SetPwdSuccess" ? "Your password has been set."
            //            : message == "RemoveLoginSuccess" ? "The account was removed."
            //            : message == "AddPhoneNumberSuccess" ? "Phone number has been added"
            //            : message == "RemovePhoneNumberSuccess" ? "Phone number was removed"
            //            : String.Empty;
            //        successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
            //    }

            //    string username = User.Identity.Name;
            //    string id = User.Identity.GetUserId();
            //    string directory = Server.MapPath("~/UploadedFiles/ProfileImages/") + id;

            //    if (!Directory.Exists(directory))
            //    {
            //        this.MyImage.ImageUrl = "~/Content/minion-hello.jpg";
            //    }
            //    else
            //    {
            //        this.MyImage.ImageUrl = UserService.GetById(id).ProfilePhotoUrl;
            //    }


            //}
        }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        // Remove phonenumber from user
        protected void RemovePhone_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var result = manager.SetPhoneNumber(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return;
            }
            var user = manager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                Response.Redirect("/Account/Manage?m=RemovePhoneNumberSuccess");
            }
        }

        // DisableTwoFactorAuthentication
        protected void TwoFactorDisable_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            manager.SetTwoFactorEnabled(User.Identity.GetUserId(), false);

            Response.Redirect("/Account/Manage");
        }

        //EnableTwoFactorAuthentication 
        protected void TwoFactorEnable_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            manager.SetTwoFactorEnabled(User.Identity.GetUserId(), true);

            Response.Redirect("/Account/Manage");
        }

        //protected void UploadButton_Click(object sender, EventArgs e)
        //{
        //    if (ImageFileUpload.HasFile)
        //    {
        //        try
        //        {
        //            if (ImageFileUpload.PostedFile.ContentType == "image/jpeg")
        //            {
        //                if (ImageFileUpload.PostedFile.ContentLength <= 16 * 1000 * 1024)
        //                {
        //                    string username = User.Identity.Name;
        //                    string id = User.Identity.GetUserId();
        //                    string directory = Server.MapPath("~/UploadedFiles/ProfileImages/") + id;
        //                    string filename = Guid.NewGuid().ToString() + ".jpg";
        //                    string path = directory + "/" + filename;
        //                    string url = "~/UploadedFiles/ProfileImages/" + id + "/" + filename;

        //                    if (!Directory.Exists(directory))
        //                    {
        //                        Directory.CreateDirectory(directory);
        //                    }

        //                    ImageFileUpload.SaveAs(path);
        //                    UserService.ChangeProfilePhotoUrl(id, url);
        //                    this.MyImage.ImageUrl = url;
        //                }
        //                else
        //                {
                            
        //                }
        //            }
        //            else
        //            {
                       
        //            }
        //        }
        //        catch (Exception ex)
        //        {
                    
        //        }
        //    }
        //}

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<PlaylistSystem.Models.Playlist> ListView1_GetData()
        {
            string id = User.Identity.GetUserId();
            return this.PlaylistService.GetAll().Where(p=>p.Creator.Id == id);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public User lvProfile_GetData()
        {
            string id = User.Identity.GetUserId();
            return this.UserService.GetById(id);
        }
    }
}