using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventManagementAPI.Models;

namespace EventManagementAPI.Repositories
{
    public interface IRegistrationRepository
    {
        Task<IEnumerable<Registration>> GetAllAsync();
        Task<Registration> GetByIdAsync(Guid id);
        Task<Registration> AddAsync(Registration registration);
        Task<Registration> UpdateAsync(Registration registration);
        Task<bool> DeleteAsync(Guid id);
    }
}
