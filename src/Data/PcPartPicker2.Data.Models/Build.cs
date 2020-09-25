namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Build : BaseDeletableModel<string>
    {
        public Build()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Upvotes { get; set; }

        public int DownVotes { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public string CaseId { get; set; }

        public Case Case { get; set; }

        public string CpuId { get; set; }

        public Cpu Cpu { get; set; }

        public string CpuCoolerId { get; set; }

        public CpuCooler CpuCooler { get; set; }

        public string MemoryId { get; set; }

        public Memory Memory { get; set; }

        public string MotherboardId { get; set; }

        public Motherboard Motherboard { get; set; }

        public string PowerSupplyId { get; set; }

        public PowerSupply PowerSupply { get; set; }

        public string StorageId { get; set; }

        public Storage Storage { get; set; }

        public string VideoCardId { get; set; }

        public VideoCard VideoCard { get; set; }
    }
}
