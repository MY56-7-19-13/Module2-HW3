using Homework3.Interface;

namespace Homework3.Models
{
    public class Sweets : IShowInfoSweets, IComparable<Sweets>
    {
        private string _name;
        private int _weight;
        private int _calories;
        public string Name
        {
            get { return _name; }
        }

        public int Weight
        {
            get { return _weight; }
        }

        public int Calories
        {
            get { return _calories; }
        }

        public Sweets(string name, int weight, int calories)
        {
            _name = name;
            _weight = weight;
            _calories = calories;
        }

        public string GetInfoSweets()
        {
            return $"Title: {_name} | Weight: {_weight}g | Calories: {_calories}";
        }

        public int CompareTo(Sweets? sweets)
        {
            if (sweets != null)
            {
            }

            return Weight.CompareTo(sweets.Weight);
        }
    }
}
