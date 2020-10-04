namespace PcPartPicker2.Web.ViewModels.Blogs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Web.ViewModels.Builds;

    public class BlogListVIewModel
    {
        public ICollection<BlogViewModel> Blogs { get; set; }
    }
}
