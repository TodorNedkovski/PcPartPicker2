namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;
    using PcPartPicker2.Data.Models.Enums;

    public class CpuCooler : BaseDeletableModel<string>
    {
        public CpuCooler()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public double Height { get; set; }

        public Bearing Bearing { get; set; }

        public string CPUSocket { get; set; }

        public bool WaterCooled { get; set; }

        public bool Fanless { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
