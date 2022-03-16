using System.ComponentModel.DataAnnotations;

namespace ModelBuilderPractice.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Journal> Journals { get; set; }

        public User()
        {
            Journals = new HashSet<Journal>();
        }
    }
}
