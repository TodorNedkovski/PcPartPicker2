namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using PcPartPicker2.Data.Common.Models;
    using PcPartPicker2.Data.Models.Enums;

    public class Motherboard : BaseDeletableModel<string>
    {
        public Motherboard()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public string Socket { get; set; }

        public string Chipset { get; set; }

        public double MaxMemory { get; set; }

        public MemoryType MemoryType { get; set; }

        public int MemorySlots { get; set; }

        public string WirelessNetworking { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
