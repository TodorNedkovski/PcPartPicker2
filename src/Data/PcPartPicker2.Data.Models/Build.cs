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

        public ApplicationUser Author { get; set; }

        //public ICollection<string> Parts { get; set; }

        //public ICollection<string> Comments { get; set; }
    }
}
