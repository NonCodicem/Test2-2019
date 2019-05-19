using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test2_Serge_Fabre
{
    public enum SterType { WitteReus, BlauweReus, GeleDwerg, VampierSter }
    class Ster
    {
        public String Naam { get; }
        public SterType Type { get; set; }
        public List<Planeet> Planeten { get; } = new List<Planeet>();
        public int AantalPlaneten { get; }

        public Ster(string nm, SterType type)
        {
            Naam = nm;
            Type = type;

        }

        public string ZoekGrootstePlaneet()
        {
            string grootstePlaneet = null;
            double max = 0;
            foreach (var item in Planeten)
            {
                if (item.Diameter > max)
                {
                    max = item.Diameter;
                    grootstePlaneet = item.Naam;
                }
            }

            return grootstePlaneet;
        }

    }
}
