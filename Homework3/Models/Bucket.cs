using Homework3.Models.Candy;
using Homework3.Models.OtherSweets;

namespace Homework3.Models
{
    public class Bucket
    {
        private CaramelCandy[] _caramelCandies =
        {
             new CaramelCandy("Bim-Bom", 1000, 360, "caramel", "fruit-and-berry"),
             new CaramelCandy("Barbarys", 500, 120, "caramel", "barberry"),
             new CaramelCandy("Butter Milk", 250, 74, "caramel", "milk"),
             new CaramelCandy("After Party", 100, 50, "caramel", "mint"),
             new CaramelCandy("Happy ORO", 140, 63, "caramel", "cofee")
        };
        private ChocolateCandy[] _chocolateCandies =
        {
             new ChocolateCandy("Roshen", 70, 35, "chocolate", "dark"),
             new ChocolateCandy("Millenium", 210, 420, "chocolate", "white"),
             new ChocolateCandy("Cadbury Eclair", 420, 113, "chocolate", "nut"),
             new ChocolateCandy("Milka", 70, 15, "chocolate", "milk-oreo"),
             new ChocolateCandy("Arrow", 150, 42, "chocolate", "dark"),
        };
        private Cookies[] _cookiesList =
        {
             new Cookies("Oreo", 170, 497, "cookies", "sand base with vanilla filling"),
             new Cookies("BISCOTTI", 1300, 449, "cookies", "sand base in glaze"),
             new Cookies("Belvita", 225, 446, "cookies", "sand base with nuts/cacao/honey"),
             new Cookies("2-Crack", 235, 496, "cookies", "cracker with hazelnuts"),
             new Cookies("Jacobsens", 150, 342, "cookies", "oily with chocolate"),
        };
        private Marmalades[] _marmaladesList =
        {
             new Marmalades("HARIBO", 175, 30, "marmalade", "multicolor"),
             new Marmalades("Choco-Bananas", 180, 45, "marmalade", "yellow"),
             new Marmalades("Crazy Bee", 100, 32, "marmalade", "multicolor with friuts"),
             new Marmalades("Bob Snail", 120, 10, "marmalade", "brown (without sugar)"),
             new Marmalades("Sharks", 110, 15, "marmalade", "blue"),
        };

        public CaramelCandy[] GetCaramelCandies()
        {
            for (int i = 0; i < _caramelCandies.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_caramelCandies[i].GetInfoSweets());
            }

            return _caramelCandies;
        }

        public ChocolateCandy[] GetChocolateCandies()
        {
            for (int i = 0; i < _chocolateCandies.Length; i++)
            {
                Console.Write(i + 6 + ". ");
                Console.WriteLine(_chocolateCandies[i].GetInfoSweets());
            }

            return _chocolateCandies;
        }

        public Cookies[] GetCookiesList()
        {
            for (int i = 0; i < _cookiesList.Length; i++)
            {
                Console.Write(i + 11 + ". ");
                Console.WriteLine(_cookiesList[i].GetInfoSweets());
            }

            return _cookiesList;
        }

        public Marmalades[] GetMarmaladesList()
        {
            for (int i = 0; i < _marmaladesList.Length; i++)
            {
                Console.Write(i + 16 + ". ");
                Console.WriteLine(_marmaladesList[i].GetInfoSweets());
            }

            return _marmaladesList;
        }
    }
}
