namespace battleship.Data
{
    public class Enums
    {
        public enum GameState
        {
            ACTIVE, ENDED, ABORTED
        }

        public enum TurnType
        {
            SHOOTMISSILE, PLACESHIP
        }

        public enum MissileType
        {
            SIMPLE, AOE
        }
    }
}
