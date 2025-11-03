using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace ejada.employees.Web.Components.Toolbar.LoginLink;

public class LoginLinkViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        //return View("~/Components/Toolbar/LoginLink/Default.cshtml");
        var loginUrl = "https://localhost:44355/Account/Login?returnUrl=https://localhost:44378";
        return View("~/Components/Toolbar/LoginLink/Default.cshtml", loginUrl);

    }
}
