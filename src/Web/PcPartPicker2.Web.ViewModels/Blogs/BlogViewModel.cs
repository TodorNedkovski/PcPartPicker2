namespace PcPartPicker2.Web.ViewModels.Blogs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Models;
    using PcPartPicker2.Services.Mapping;

    public class BlogViewModel : IMapFrom<Blog>, IMapTo<BlogViewModel>
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
