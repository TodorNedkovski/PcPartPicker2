namespace PcPartPicker2.Web.Controllers
{
    using System.Diagnostics;

    using PcPartPicker2.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using PcPartPicker2.Services.Data;
    using Microsoft.AspNetCore.Server.IIS.Core;
    using System.Collections;
    using PcPartPicker2.Web.ViewModels.Builds;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class HomeController : BaseController
    {
        private readonly IBuildService buildService;

        public HomeController(IBuildService buildService)
        {
            this.buildService = buildService;
        }

        public IActionResult Index()
        {
            var builds = this.buildService.GetAllAsync<BuildViewModel>(10);

            return this.View(builds);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
