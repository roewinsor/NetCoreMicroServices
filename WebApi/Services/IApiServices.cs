using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IApiService
    {
        Task<IEnumerable<Api>> ReadAllAsync();
        Task<Api> ReadOneAsync(string apiName);
        Task<bool> IsClanExistsAsync(string apiName);
        Task<Api> CreateAsync(Api api);
        Task<Api> UpdateAsync(Api api);
        Task<Api> DeleteAsync(string apiName);
    }
}
