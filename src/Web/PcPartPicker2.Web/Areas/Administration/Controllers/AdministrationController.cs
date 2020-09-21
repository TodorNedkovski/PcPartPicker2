namespace PcPartPicker2.Web.Areas.Administration.Controllers
{
    using PcPartPicker2.Common;
    using PcPartPicker2.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
