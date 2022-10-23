using battleship.Data.Models;

namespace battleship.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public double Elo { get; set; }
        public int Points { get; set; }
        public UserShip UserShip { get; set; }

    }
}
