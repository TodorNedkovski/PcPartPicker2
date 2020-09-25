namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Case : BaseDeletableModel<string>
    {
        public Case()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public string Type { get; set; }

        public string Color { get; set; }

        public string PowerSupply { get; set; }

        public string SidePanelWindow { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double VolumeInLiters { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
