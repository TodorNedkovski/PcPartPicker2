namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Storage : BaseDeletableModel<string>
    {
        public Storage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public double Capacity { get; set; }

        public double Price { get; set; }

        public double PricePerGb => this.Price / this.Capacity;

        public int Cache { get; set; }

        public string Interface { get; set; }

        public bool IsNVME { get; set; }
    }
}
