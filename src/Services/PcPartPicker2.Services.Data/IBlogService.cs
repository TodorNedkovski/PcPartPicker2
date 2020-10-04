namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PcPartPicker2.Data.Models;

    public interface IBlogService
    {
        Task<ICollection<T>> GetAllAsync<T>(int take);

        Task AddAsync<T>(Blog build);

        Task DeleteByIdAsync(string id);
    }
}
