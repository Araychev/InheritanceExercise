namespace Restaurant
{
   public class Cake : Dessert
    {

        private const double DefoltGrams = 250;
        private const double DefoltCalories = 1000;
        private const decimal DefoultPrice = 5m;

        public Cake(string name) 
            : base(name, DefoultPrice, DefoltGrams, DefoltCalories)
        {
        }
    }
}
