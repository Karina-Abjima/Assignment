namespace StudentAPI.Entities
{
    public class StudentDto

    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RollNo { get; set; }
        public string Address { get; set; } = null!;
        public string FamilyName { get; set; } = null!;
        public long Contact { get; set; }
    }
}
