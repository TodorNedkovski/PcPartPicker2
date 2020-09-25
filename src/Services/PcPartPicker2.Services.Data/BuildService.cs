namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PcPartPicker2.Data.Common.Repositories;
    using PcPartPicker2.Data.Models;

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

        public async Task GetAllAsync<T>(int take)
        {
            throw new NotImplementedException();
        }
    }
}
