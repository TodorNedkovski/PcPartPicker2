namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class Blog : BaseDeletableModel<string>
    {
        public Blog()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<BlogComment> BlogComments { get; set; }
    }
}
