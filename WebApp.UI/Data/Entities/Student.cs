namespace WebApp.UI.Data.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        //public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string Photo { get; set; }
        public string Info { get; set; }

    }
}