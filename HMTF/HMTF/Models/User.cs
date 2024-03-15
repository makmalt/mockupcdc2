namespace HMTF.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Departement { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedDateOnly => CreatedAt.Date;
    }
}
