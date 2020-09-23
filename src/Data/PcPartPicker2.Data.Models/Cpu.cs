namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Cpu : BaseDeletableModel<string>
    {
        public Cpu()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int CoreCount { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public double CoreClock { get; set; }

        public double BoostClock { get; set; }

        public bool IntegratedGraphics { get; set; }

        public double MaximumSupportedMemory { get; set; }
    }
}
