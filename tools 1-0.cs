using System;

namespace GGT
{
    internal class Program
    {
        static int GGT(int a, int b)
        {
            int ggt = 0;
            if (a > b)
            {
                ggt = b;
                int Rest_alt = b;
                int divisor = b;
                Math.DivRem(a, b, out int Rest);

                while (Rest is not 0)
                {
                    Rest_alt = Rest;
                    Math.DivRem(divisor, Rest_alt, out Rest);
                    divisor = Rest_alt;
                }
                if (Rest == 0)
                {
                    ggt = Rest_alt;
                }
                
            }

            if (b > a)
            {
                ggt = a;
                int Rest_alt = a;
                int divisor = a;
                Math.DivRem(b, a, out int Rest);

                while (Rest is not 0)
                {
                    Rest_alt = Rest;
                    Math.DivRem(divisor, Rest_alt, out Rest);
                    divisor = Rest_alt;
                }
                if (Rest == 0)
                {
                    ggt = Rest_alt;
                }
                
            }

            if (a == b)
            {
                ggt = a;
                
            }
            
            return ggt;
            
        }
        static int KGV(int a, int b)
        {
            int ggT = GGT(a, b);
            int kgv = a * b / ggT;
            return kgv;
        }

        static string KUERZEN(int Zaeler, int Nenner)
        { 
            int ggT = GGT(Zaeler, Nenner);
            int zaeler_kurz = Zaeler / ggT;
            int nenner_kurz = Nenner / ggT;
            string Bruch_gekürzt = zaeler_kurz + "/" + nenner_kurz;
            return Bruch_gekürzt;

            
        }
        static void Main(string[] args)
        {   
           
            int a = 69;
            int b = 420;
            int Zaeler = 69;
            int Nenner = 420;
            GGT(a, b);
            KGV(a, b);
            KUERZEN(Zaeler, Nenner);
            int ggT = GGT(a, b);
            int kGv = KGV(a, b);
            string Bruch_kurz = KUERZEN(Zaeler, Nenner);
            
            Console.WriteLine("ggT(" + a + "," + b +") = " + ggT + "               presented by Passivkonto GmbH");
            Console.WriteLine("kGv(" + a + "," + b + ") = " + kGv + "               presented by Passivkonto GmbH"  );
            Console.WriteLine("der Bruch (" + Zaeler + "/" + Nenner + ") ist gekuertzt: " + Bruch_kurz + "            presented by Passivkonto GmbH");
            // button GGT = GGT
            // Button Kgv = GGT + KGV
            // button kürzen = GGT + KUERZEN

        }
    }
}