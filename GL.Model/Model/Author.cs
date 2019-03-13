using System.ComponentModel.DataAnnotations;

namespace GL.Model.Model
{
    public class Author:BaseEntity
    {
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        
    }
}