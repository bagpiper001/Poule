using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PouleCreation
{
    public class Poule
    {
        String name;
        List<Judoka> judokas;
        public Poule()
        {
            name = "poule 1";
            judokas = new List<Judoka>();
        }
        public Poule(String name)
        {
            this.name = name;
            judokas = new List<Judoka>();
        }

        public String getName()
        {
            return name;
        }
    }
}
