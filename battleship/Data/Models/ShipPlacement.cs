
using battleship.Models;
using static battleship.Data.Enums;

namespace battleship.Data.Models
{
    public class ShipPlacement
    {
        public int Id { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public bool IsVerticalRotation { get; set; }
        public Ship Ship { get; set; }
        public User User { get; set; }
        public GameMatch GameMatch { get; set; }
    }
}
