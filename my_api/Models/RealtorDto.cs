namespace WebApplication1_API.Models
{
    public class RealtorDto
    {

        // Ensure Title is not nullable, as it should always have a value
        public string Title { get; set; } = string.Empty;

        // Foreign key for Office
        public int OfficeId { get; set; }

        // Marking Office as required
        public required OfficeDto Office { get; set; }
    }
}

// Models define the structure of your data but shouldn't contain business logic or data access logic. This keeps your models clean and focused.
