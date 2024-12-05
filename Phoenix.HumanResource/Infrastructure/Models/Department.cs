namespace Infrastructure.Models
{
    public class Department : Entity
    {
        public string? Name { get; set; }

        public bool IsLocked { get; set; }
    }
}
