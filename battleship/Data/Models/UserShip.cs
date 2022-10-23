using battleship.Models;

namespace battleship.Data.Models
{
    public class UserShip
    {
        public int Id { get; set; }
        public User PlayerOne { get; set; }
        public User PlayerTwo { get; set; }
    }
}
