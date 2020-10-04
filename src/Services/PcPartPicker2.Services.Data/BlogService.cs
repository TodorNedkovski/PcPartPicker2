namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using PcPartPicker2.Data.Common.Repositories;
    using PcPartPicker2.Data.Models;
    using PcPartPicker2.Services.Mapping;

    public class BlogService : IBlogService
    {
        private IDeletableEntityRepository<Blog> repository;

        public BlogService(IDeletableEntityRepository<Blog> repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync<T>(Blog blog)
        {
            await this.repository.AddAsync(blog);
        }

        public async Task DeleteByIdAsync(string id)
        {
            var blog = await this.repository.All().FirstOrDefaultAsync();
            blog.IsDeleted = true;

            await this.repository.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAllAsync<T>(int take)
        {
            return await this.repository
                .All()
                .Take(take)
                .To<T>()
                .ToListAsync();
        }
    }
}
