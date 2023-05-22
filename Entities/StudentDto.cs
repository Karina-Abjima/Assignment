using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Entities
{
    public  class StudentDto

    {
        

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50)]
       
        public int RollNo { get; set; }
        [Required]
  
        public string Address { get; set; } = null!;
        public string FamilyName { get; set; } = null!;
        public long Contact { get; set; }
    }

}