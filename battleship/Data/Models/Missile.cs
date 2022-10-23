using static battleship.Data.Enums;

namespace battleship.Data.Models
{
    public class Missile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cooldown { get; set; }
        public MissileType MissileType { get; set; }
    }
}
