namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Memory : BaseDeletableModel<string>
    {
        public Memory()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public int Module { get; set; }

        public int Sets { get; set; }

        public double Voltage { get; set; }

        public bool HeatSpreader { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
