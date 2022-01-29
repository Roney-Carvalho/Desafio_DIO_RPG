namespace DioGFTDesafio.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, int HealthPoints, string Class) : base(Name, Level, HealthPoints, Class)
        {

        }

        public string Attack()
        {
            return Name + " attacks graciously using a glamorous bow.";
        }
    }
}