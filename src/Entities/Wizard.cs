namespace dio-jogoRpg
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack()
        {
            return Name + " Atacaou com sua magia!!";
        }
    }
}