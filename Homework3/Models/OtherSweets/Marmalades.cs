using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.OtherSweets
{
    public class Marmalades : OtherSweets
    {
        private string _marmaladeColor;
        public string MarmaladeColor
        {
            get { return _marmaladeColor; }
        }

        public Marmalades(string name, int weight, int calories, string type, string marmaladeColor)
            : base(name, weight, calories, type)
        {
            _marmaladeColor = marmaladeColor;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Color: {_marmaladeColor}";
        }
    }
}
