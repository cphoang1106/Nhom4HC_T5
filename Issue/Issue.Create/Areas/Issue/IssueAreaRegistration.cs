using System.Web.Mvc;

namespace Issue.Create.Areas.Issue
{
    public class IssueAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Issue";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Issue_Create",
                "Issue/Create/{action}/{id}",
                new { Controller = "Issue", action = "Create", id = UrlParameter.Optional }
                , namespaces: new[] { "Issue.Create.Areas.Issue.Controllers" }
            );
        }
    }
}
