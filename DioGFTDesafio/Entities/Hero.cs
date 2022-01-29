namespace DioGFTDesafio.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public int HealthPoints;
        public string Class;

        public Hero(string Name, int Level, int HealthPoints, string Class)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoints = HealthPoints;
            this.Class = Class;
        }

        public string Present()
        {
            return "It's a " + Class + " called " + Name + " - Level " + Level;
        }
    }
}