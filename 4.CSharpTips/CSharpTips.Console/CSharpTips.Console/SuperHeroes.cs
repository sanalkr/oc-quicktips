using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips.Console
{
    public class SuperHeroes
    {
        List<string> _heroes = new List<string>();

        public SuperHeroes()
        {
            _heroes.Add("Tony");
            _heroes.Add("Steve");
            _heroes.Add("Thor");
            _heroes.Add("Bruce");
            _heroes.Add("Natasha");
            _heroes.Add("Barton");

        }

        public IEnumerable<string> Avengers { get { return _heroes.AsReadOnly();  } }
    }
}
