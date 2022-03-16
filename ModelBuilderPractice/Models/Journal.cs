using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderPractice.Models
{
    public class Journal
    {
        public int JournalNumber { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
