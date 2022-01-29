namespace DioGFTDesafio.Entities
{
    public class Mage : Hero
    {
        public Mage(string Name, int Level, int HealthPoints, string Class) : base(Name, Level, HealthPoints, Class)
        {

        }

        public string Attack()
        {
            return Name + " attacks wisely using breathtaking power.";
        }
    }
}