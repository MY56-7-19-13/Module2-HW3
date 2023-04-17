using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.OtherSweets
{
    public class OtherSweets : Sweets
    {
        private string _type;
        public string Type
        {
            get { return _type; }
        }

        public OtherSweets(string name, int weight, int calories, string type)
            : base(name, weight, calories)
        {
            _type = type;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Type: {_type}";
        }
    }
}
