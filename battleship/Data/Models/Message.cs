using battleship.Models;

namespace battleship.Data.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public DateTime CreationDate { get; set; }
        public Listing Listing { get; set; }
        public User User { get; set; }
    }
}
