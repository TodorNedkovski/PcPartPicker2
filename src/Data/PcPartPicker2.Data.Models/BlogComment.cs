namespace PcPartPicker2.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using PcPartPicker2.Data.Common.Models;

    public class BlogComment : BaseDeletableModel<string>
    {
        public BlogComment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationUserId")]
        public string AuthorId { get; set; }

        public string Content { get; set; }

        public Blog Blog { get; set; }

        public string BlogId { get; set; }
    }
}
