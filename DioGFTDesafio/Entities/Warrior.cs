namespace DioGFTDesafio.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Name, int Level, int HealthPoints, string Class) : base(Name, Level, HealthPoints, Class)
        {

        }

        public string Attack()
        {
            return Name + " attacks massively using pure strength.";
        }
    }
}