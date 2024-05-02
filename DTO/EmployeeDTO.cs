namespace Restaurant_site.client.DTO
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? ContactInfo { get; set; }
        public EmployeeRole Responsibility { get; set; }
    }
}
