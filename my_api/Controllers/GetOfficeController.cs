using Microsoft.AspNetCore.Mvc;
using WebApplication1_API.Data;
using WebApplication1_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1_API.Controllers.Models; // models som emanuel hjälpte mig lägga till
using WebApplication1_API.Services; // lägger till services där databasanropen sker

//  it is generally considered better practice to separate database access logic into a service layer. keeps
//  your controller focused on handling HTTP requests and delegates the data retrieval logic to a service

namespace WebApplication1_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeRealtorController : ControllerBase
    {

        private readonly OfficeService _officeService;
        private readonly RealtorService _realtorService;

        // Inject the OfficeService & RealtorService into the controller
        public OfficeRealtorController(OfficeService officeService, RealtorService realtorService)
        {
            _officeService = officeService;
            _realtorService = realtorService;
        }
  
        [HttpGet("offices")]
        public async Task<ActionResult<IEnumerable<getOfficeResponse>>> GetOffices()
        {
            var offices = await _officeService.GetOfficesAsync(); // Use OfficeService
            var result = offices.Select(office => new getOfficeResponse
            {
                Link = office.Link,
                Title = office.Title
            }).ToList();

            return Ok(result);
        }

        [HttpGet("realtors")]
        public async Task<ActionResult<IEnumerable<Realtor>>> GetRealtors()
        {
            var realtors = await _realtorService.GetRealtorsAsync(); // Use RealtorService
            var result = realtors.Select(realtors => new getRealtorResponse
            {
                Title = realtors.Title,
                //OfficeId = realtors.OfficeId,
                OfficeTitle = realtors.Office.Title // Only get the Title from the Office object

            }).ToList();
            return Ok(result);
        }
    }
}

// Controllers are responsible for handling HTTP requests,
// processing data, and returning responses. This includes filtering, projecting, and including related data.