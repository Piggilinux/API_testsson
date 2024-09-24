using WebApplication1_API.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this for data annotations

namespace WebApplication1_API.Models
{
    public class Office
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;

        // Navigation property for the list of realtors
        public List<Realtor> Realtors { get; set; } = new List<Realtor>();
    }
}

// Models define the structure of your data but shouldn't contain business logic or data access logic. This keeps your models clean and focused.