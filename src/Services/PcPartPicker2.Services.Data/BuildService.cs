namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PcPartPicker2.Data.Common.Repositories;
    using PcPartPicker2.Data.Models;
    using PcPartPicker2.Services.Mapping;

    public class BuildService : IBuildService
    {
        private IDeletableEntityRepository<Build> repository;

        public BuildService(IDeletableEntityRepository<Build> repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync<T>(T build)
        {
            await this.repository.AddAsync(new Build()
            {
            });
        }

        public async Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAllAsync<T>(int take)
        {
            return this.repository
                .AllAsNoTracking()
                .To<T>()
                .Take(take)
                .ToList();
        }
    }
}
