using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagementAPI.Models;
using EventManagementAPI.Data;

namespace EventManagementAPI.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly EventManagementContext _context;

        public RegistrationRepository(EventManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Registration>> GetAllAsync()
        {
            return await _context.Registrations.ToListAsync();
        }

        public async Task<Registration> GetByIdAsync(Guid id)
        {
            return await _context.Registrations.FindAsync(id);
        }

        public async Task<Registration> AddAsync(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration> UpdateAsync(Registration registration)
        {
            _context.Registrations.Update(registration);
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var registration = await _context.Registrations.FindAsync(id);
            if (registration == null)
                return false;

            _context.Registrations.Remove(registration);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
