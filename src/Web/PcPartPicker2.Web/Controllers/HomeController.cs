namespace PcPartPicker2.Web.Controllers
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Server.IIS.Core;
    using PcPartPicker2.Services.Data;
    using PcPartPicker2.Web.ViewModels;
    using PcPartPicker2.Web.ViewModels.Blogs;
    using PcPartPicker2.Web.ViewModels.Builds;
    using PcPartPicker2.Web.ViewModels.Index;

    public class HomeController : BaseController
    {
        private readonly IBuildService buildService;
        private readonly IBlogService blogService;

        public HomeController(IBuildService buildService, IBlogService blogService)
        {
            this.buildService = buildService;
            this.blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var builds = this.buildService.GetAllAsync<BuildViewModel>(10);
            var blogs = await this.blogService.GetAllAsync<BlogViewModel>(3);

            var indexViewModel = new IndexVIewModel()
            {
                Blogs = blogs,
                Builds = builds,
            };

            return this.View(indexViewModel);
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
