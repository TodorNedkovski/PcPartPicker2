namespace PcPartPicker2.Web.ViewModels.Builds
{
    using PcPartPicker2.Data.Models;
    using PcPartPicker2.Services.Mapping;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BuildViewModel : IMapFrom<Build>, IMapTo<BuildViewModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Upvotes { get; set; }

        public int DownVotes { get; set; }

        //public ApplicationUser Author { get; set; }

        //public Case Case { get; set; }

        //public Cpu Cpu { get; set; }

        //public CpuCooler CpuCooler { get; set; }

        //public Memory Memory { get; set; }

        //public Motherboard Motherboard { get; set; }

        //public PowerSupply PowerSupply { get; set; }

        //public Storage Storage { get; set; }

        //public VideoCard VideoCard { get; set; }
    }
}
