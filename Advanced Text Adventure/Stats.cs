namespace Console_RPG
{
    struct Stats
    {
        public int strength;
        public int defense;
        public int speed;
        public int magic;
        public int resistance;

        public Stats(int strength, int defense, int speed, int magic, int resistance)
        {
            this.strength = strength;
            this.defense = defense;
            this.speed = speed;
            this.magic = magic;
            this.resistance = resistance;
        }
    }
}