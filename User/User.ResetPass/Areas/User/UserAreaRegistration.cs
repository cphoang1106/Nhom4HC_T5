using System.Web.Mvc;

namespace User.ResetPass.Areas.User
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
                "User_ResetPass",
                "User/ResetPass/{action}/{id}",
                new { Controller = "ResetPass", action = "ResetPass", id = UrlParameter.Optional },
                namespaces: new[] { "User.ResetPass.Areas.User.Controllers" }
            );
        }
    }
}
