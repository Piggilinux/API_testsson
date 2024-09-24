using WebApplication1_API.Data;
using WebApplication1_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

// OfficeService.cs in the Services folder handles the database calls for offices, such as fetching the list of offices from the database

namespace WebApplication1_API.Services
{
    public class OfficeService
    {
        private readonly AppDbContext _context;

        public OfficeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Office>> GetOfficesAsync()
        {
            //return await _context.Offices.ToListAsync(); 
            // await= väntar tills all data är hämtad
            // _context.office hämtar all data ifrån table
            // tolistasync lägger in all data till objekt (alltså klasserna som skapats)
            return await _context.Offices
                     .Select(o => new Office
                     {
                         Title = o.Title,
                         Link = o.Link
                     })
                     .ToListAsync();
        }
    }
}
