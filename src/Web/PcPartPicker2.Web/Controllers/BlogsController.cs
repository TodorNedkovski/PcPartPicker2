namespace PcPartPicker2.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using PcPartPicker2.Services.Data;
    using PcPartPicker2.Web.ViewModels.Blogs;

    public class BlogsController : Controller
    {
        private IBlogService blogService;

        public BlogsController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        public async Task<IActionResult> All()
        {
            var blogs = await this.blogService.GetAllAsync<BlogViewModel>(3);

            return this.View(blogs);
        }
    }
}
