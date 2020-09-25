namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    using PcPartPicker2.Data.Common.Models;

    public class VideoCard : BaseDeletableModel<string>
    {
        public VideoCard()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Manufacturer { get; set; }

        public string Chipset { get; set; }

        public string Memory { get; set; }

        public string MemoryType { get; set; }

        public int CoreClock { get; set; }

        public int BoostClock { get; set; }

        public int EffectiveMemoryClock { get; set; }

        public string Interface { get; set; }

        public int HDMIPorts { get; set; }

        public int CoolingFansCount { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
    }
}
