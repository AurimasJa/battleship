using battleship.Data;
using static battleship.Data.Enums;

namespace battleship.Models
{
    public class GameMatch
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public GameState GameState { get; set; }
        public Listing Listing { get; set; }
        public User User { get; set; }

    }
}
