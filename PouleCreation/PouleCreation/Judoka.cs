using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PouleCreation
{
    class Judoka
    {
        String name;
        String belt;
        int weight;
        Poule poule;
        public Judoka(String name, String belt, int weight)
        {
            this.name = name;
            this.belt = belt;
            this.weight = weight;
        }
        
        public Judoka(String name, String belt, int weight, Poule poule)
        {
            this.name = name;
            this.belt = belt;
            this.weight = weight;
            this.poule = poule;
        }

        public String getName()
        {
            return name;
        }

        public String getBelt()
        {
            return belt;
        }

        public int getWeight()
        {
            return weight;
        }
    }
}
