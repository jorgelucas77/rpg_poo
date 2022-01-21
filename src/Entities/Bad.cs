namespace rpg_poo.src.Entities
{
    public class Bad : Hero
    {

        public Bad(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public override string Attack(){
            return this.Name + " Atacou com o seu sabre vermelho.";
        }

         public string Attack(int Bonus){
             if (Bonus >6) {
                return this.Name + " Atacou com energia efétiva e com um bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com energia fraca e com um bonus de " + Bonus;
            }
        }
    }
}