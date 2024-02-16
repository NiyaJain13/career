//using System.ComponentModel.DataAnnotations;
namespace career.Models
{
    public class Student
    {
        public int regno { get; set; }
  //      [Required]
        public string? name { get; set; }
        public string? email {  get; set; }
        public string? phone {  get; set; }
        public string? pass {  get; set; }

    }
}
