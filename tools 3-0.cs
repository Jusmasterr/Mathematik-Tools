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

        static int[] KUERZEN(int Zaeler, int Nenner)
        {
            int ggT = GGT(Zaeler, Nenner);
            int zaeler_kurz = Zaeler / ggT;
            int nenner_kurz = Nenner / ggT;
            int[] Bruch_gekürzt = { zaeler_kurz, nenner_kurz };
            return Bruch_gekürzt;


        }

        static int[] ADDITION(int z_1, int n_1, int z_2, int n_2)
        {
            int zaeler = z_1 * n_2 + z_2 * n_1;
            int nenner = n_1 * n_2;
            int[] Bruch_k = KUERZEN(zaeler, nenner);
            return Bruch_k;
        }

        static int[] SUBTRAKTION(int z_1, int n_1, int z_2, int n_2)
        {
            int zaeler = z_1 * n_2 - z_2 * n_1;
            int nenner = n_1 * n_2;
            int[] Bruch_k = KUERZEN(zaeler, nenner);
            return Bruch_k;
        }

        static int[] MULTIPLIKATION(int z_1, int n_1, int z_2, int n_2)
        {
            int zaeler = z_1 * z_2;
            int nenner = n_1 * n_2;
            int[] Bruch_k = KUERZEN(zaeler, nenner);
            return Bruch_k;
        }

        static int[] DIVISION(int z_1, int n_1, int z_2, int n_2)
        {
            int zaeler = z_1 * n_2;
            int nenner = n_1 * z_2;
            int[] Bruch_k = KUERZEN(zaeler, nenner);
            return Bruch_k;

        }

        static void Main(string[] args)
        {
            // test input
            int a = 3;              //GGT & KGV
            int b = 9;              //GGT & KGV
            int Zaeler = 69;        //kürzen
            int Nenner = 420;       //kürzen
            int Zaeler_1 = 69;      //anderes
            int Nenner_1 = 420;     //anderes
            int Zaeler_2 = 420;     //anderes
            int Nenner_2 = 69;      //anderes

            //variablen / arrays
            //int ggT = GGT(a, b);
            //int kGv = KGV(a, b);
            int[] Bruch_kurz = KUERZEN(Zaeler, Nenner);
            int[] Addition = ADDITION(Zaeler_1, Nenner_1, Zaeler_2, Nenner_2);
            int[] Subtraktion = SUBTRAKTION(Zaeler_1, Nenner_1, Zaeler_2, Nenner_2);
            int[] Multiplikation = MULTIPLIKATION(Zaeler_1, Nenner_1, Zaeler_2, Nenner_2);
            int[] Division = DIVISION(Zaeler_1, Nenner_1, Zaeler_2, Nenner_2);

            //variablen für einzelne textfelder
            int ggT = GGT(a, b);
            int kGv = KGV(a, b);
            int Zaeler_k = Bruch_kurz[0];
            int Nenner_k = Bruch_kurz[1];
            int Zaeler_A_k = Addition[0];
            int Nenner_A_k = Addition[1];
            int Zaeler_S_k = Subtraktion[0];
            int Nenner_S_k = Subtraktion[1];
            int Zaeler_M_k = Multiplikation[0];
            int Nenner_M_k = Multiplikation[1];
            int Zaeler_D_k = Division[0];
            int Nenner_D_k = Division[1];

            //test output
            string Kurz = Bruch_kurz[0] + "/ " + Bruch_kurz[1];
            string Addition_t = Addition[0] + "/ " + Addition[1];
            string Subtraktion_t = Subtraktion[0] + "/ " + Subtraktion[1];
            string Multiplikation_t = Multiplikation[0] + "/ " + Multiplikation[1];
            string Division_t = Division[0] + "/ " + Division[1];
            Console.WriteLine("ggT(" + a + "," + b + ") = " + ggT + "               presented by Passivkonto GmbH");
            Console.WriteLine("kGv(" + a + "," + b + ") = " + kGv + "               presented by Passivkonto GmbH");
            Console.WriteLine("der Bruch (" + Zaeler + "/" + Nenner + ") ist gekuertzt: " + Kurz + "            presented by Passivkonto GmbH");
            Console.WriteLine(Addition_t);
            Console.WriteLine(Subtraktion_t);
            Console.WriteLine(Multiplikation_t);
            Console.WriteLine(Division_t);
        }
    }
}