using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.Candy
{
    public class CaramelCandy : Candy
    {
        private string _caramelFilling;
        public string CaramelFilling
        {
            get { return _caramelFilling; }
        }

        public CaramelCandy(string name, int weight, int calories, string taste, string caramelFilling)
            : base(name, weight, calories, taste)
        {
            _caramelFilling = caramelFilling;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Filling: {_caramelFilling}";
        }
    }
}
