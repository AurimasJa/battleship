using battleship.Models;
using static battleship.Data.Enums;

namespace battleship.Data.Models
{
    public class Turn
    {
        public int Id { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public TurnType TurnType { get; set; }
        public GameMatch GameMatch { get; set; }

    }
}
