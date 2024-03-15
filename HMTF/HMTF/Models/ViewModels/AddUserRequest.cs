namespace HMTF.Models.ViewModels
{

    // add DATA KARYAWAN  (not user)
    public class AddUserRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Departement { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedDateOnly => CreatedAt.Date;
    }

}
