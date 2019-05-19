using System;
using System.Collections.Generic;
using System.Text;

namespace AD2_Test2_Serge_Fabre
{
    class Planeet
    {
        public String Naam { get; set; }
        public double Diameter { get; set; }
        public bool IsGeldig
        {
            get
            {
                if (Naam == null || Diameter < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public Planeet(string nm, double diam)
        {
            if (String.IsNullOrWhiteSpace(nm))
            {
                Naam = null;
            }
            else
            {
                Naam = nm;
            }

            if (diam <= 0)
            {
                Diameter = -1;
            }
            else
            {
                Diameter = diam;
            }

        }

        public static string GrootstePlaneet(Planeet eerste, Planeet tweede)
        {
            string planeet = null;
            if (eerste == null & tweede == null)
            {
                planeet = null;
            }
            if (eerste == null | tweede == null)
            {
                if (eerste == null)
                {
                    planeet = tweede.Naam;
                }
                else
                {
                    planeet = eerste.Naam;
                }
            }
            else
            {
                if (eerste.Diameter > tweede.Diameter)
                {
                    planeet = eerste.Naam;
                }
                else
                {
                    planeet = tweede.Naam;
                }

            }

            return planeet;

        }
    }
}
