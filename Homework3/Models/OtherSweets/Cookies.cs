using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models.OtherSweets
{
    public class Cookies : OtherSweets
    {
        private string _cookiesType;
        public string CookiesType
        {
            get { return _cookiesType; }
        }

        public Cookies(string name, int weight, int calories, string type, string cookiesType)
            : base(name, weight, calories, type)
        {
            _cookiesType = cookiesType;
        }

        public new string GetInfoSweets()
        {
            return base.GetInfoSweets() + $" | Structure {_cookiesType}";
        }
    }
}
