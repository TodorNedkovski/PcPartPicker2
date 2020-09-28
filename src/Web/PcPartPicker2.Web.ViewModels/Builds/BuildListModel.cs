namespace PcPartPicker2.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Web.ViewModels.Builds;

    public class BuildListModel
    {
        public ICollection<BuildViewModel> Builds { get; set; }

        public int Page { get; set; }
    }
}
