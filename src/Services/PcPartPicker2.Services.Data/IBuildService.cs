namespace PcPartPicker2.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBuildService
    {
        ICollection<T> GetAllAsync<T>(int take);

        Task AddAsync<T>(T build);

        Task DeleteByIdAsync(string id);
    }
}
