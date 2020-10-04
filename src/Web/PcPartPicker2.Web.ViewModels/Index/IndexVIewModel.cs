namespace PcPartPicker2.Web.ViewModels.Index
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Web.ViewModels.Blogs;
    using PcPartPicker2.Web.ViewModels.Builds;

    public class IndexVIewModel
    {
        public ICollection<BuildViewModel> Builds { get; set; }

        public ICollection<BlogViewModel> Blogs { get; set; }
    }
}
