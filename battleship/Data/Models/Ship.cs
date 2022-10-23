namespace battleship.Data.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public Missile Missile { get; set; }
    }
}
