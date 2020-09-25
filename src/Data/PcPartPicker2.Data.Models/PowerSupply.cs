namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class PowerSupply : BaseDeletableModel<string>
    {
        public PowerSupply()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public string FormFactor { get; set; }

        public double Wattage { get; set; }

        public int Length { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
