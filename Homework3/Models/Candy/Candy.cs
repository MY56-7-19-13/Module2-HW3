using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.Candy
{
    public class Candy : Sweets
    {
        private string _taste;
        public string Taste
        {
            get { return _taste; }
        }

        public Candy(string name, int weight, int calories, string taste)
            : base(name, weight, calories)
        {
            _taste = taste;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Taste: {_taste}";
        }
    }
}
