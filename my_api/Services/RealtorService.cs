using WebApplication1_API.Data;
using WebApplication1_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

// RealtorService.cs in the Services folder handles the database calls for realtors, such as fetching the list of realtors from the database

namespace WebApplication1_API.Services
{
    public class RealtorService
    {
        private readonly AppDbContext _context;

        public RealtorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Realtor>> GetRealtorsAsync()
        {
            //return await _context.Realtors.ToListAsync();
            return await _context.Realtors
                .Select(o => new Realtor
                {
                    Title = o.Title,
                    //OfficeId = o.OfficeId,
                    Office = o.Office
                })
                .ToListAsync();
        }
    }
}
