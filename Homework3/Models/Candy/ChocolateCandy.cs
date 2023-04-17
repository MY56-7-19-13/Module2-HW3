using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.Candy
{
    public class ChocolateCandy : Candy
    {
        private string _chocolateBasis;
        public string ChocolateBasis
        {
            get { return _chocolateBasis; }
        }

        public ChocolateCandy(string name, int weight, int calories, string taste, string chocokateBasis)
            : base(name, weight, calories, taste)
        {
            _chocolateBasis = chocokateBasis;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Basic: {_chocolateBasis}";
        }
    }
}
