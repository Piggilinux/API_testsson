using WebApplication1_API.Models;

namespace WebApplication1_API.Controllers.Models
{
    public class getRealtorResponse
    {
        public string Title { get; set; } = string.Empty;
        //public int OfficeId { get; set; } = 0;
        public string OfficeTitle { get; set; } = string.Empty; // Only include the office title
        //public required Office Office { get; set; }
    }
}
