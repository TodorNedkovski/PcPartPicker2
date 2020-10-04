namespace PcPartPicker2.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PcPartPicker2.Data.Models;

    public class BlogSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var blogs = new List<Blog>
            {
                new Blog()
                {
                    Title = "Title 1",
                    Description = "Desc 3qelwtgwr",
                },
                new Blog()
                {
                    Title = "Title 2",
                    Description = "Desc 3qelwtgwr",
                },
                new Blog()
                {
                    Title = "Title 3",
                    Description = "Desc 3qelwtgwr",
                },
                new Blog()
                {
                    Title = "Title 4",
                    Description = "Desc 3qelwtgwr",
                },
            };

            await dbContext.AddRangeAsync(blogs);
            await dbContext.SaveChangesAsync();
        }
    }
}
