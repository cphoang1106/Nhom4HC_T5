using System.Web.Mvc;

namespace User.Register.Areas.User
{
    public class UserAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "User_Register",
                "User/Register/{action}/{id}",
                new { Controller="User",action = "Register", id = UrlParameter.Optional }
                , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            );
            //context.MapRoute(
            //    "Post_User_Register",
            //    "User/RegisterUser",
            //    new { Controller = "User", action = "RegisterUser", id = UrlParameter.Optional }
            //    , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            //);
            //context.MapRoute(
            //    "User_CheckUserName",
            //    "User/CheckUserName",
            //    new { Controller = "User", action = "CheckUserName", id = UrlParameter.Optional }
            //    , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            //);
            //context.MapRoute(
            //    "User_GetCaptcha",
            //    "User/GetCaptchaImage",
            //    new { Controller = "User", action = "GetCaptchaImage", id = UrlParameter.Optional }
            //    , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            //);
            //context.MapRoute(
            //    "User_CheckCaptchaValue",
            //    "User/CheckCaptchaValue",
            //    new { Controller = "User", action = "CheckCaptchaValue", id = UrlParameter.Optional }
            //    , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            //);
            //context.MapRoute(
            //    "User_GetCaptChaImage",
            //    "User/GetCaptChaImage",
            //    new { Controller = "User", action = "GetCaptChaImage", id = UrlParameter.Optional }
            //    , namespaces: new[] { "User.Register.Areas.User.Controllers" }
            //);
        }
    }
}
