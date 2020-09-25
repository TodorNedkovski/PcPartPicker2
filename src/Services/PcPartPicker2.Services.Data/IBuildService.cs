namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBuildService
    {
        Task GetAllAsync<T>(int take);

        Task AddAsync<T>(T build);

        Task DeleteByIdAsync(string id);
    }
}
