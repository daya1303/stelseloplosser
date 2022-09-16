using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace stelselOplosser
{
    class program
    {
        static void Main()
        {
            //stelsel
            // aantal variabelen : xa + yb = z
            // a en b

            //initialisatie
            double x1, y1, z1, x2, y2, Z2, uitkomstA, uitkomstB ;

            // declaratie
            Console.WriteLine("dit is een stelsel oplosser geef de drie getallen van je eerste stelsel in");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("geef de drie getallen van je tweede stelsel nu in");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Z2 = -Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Z2);
            Console.WriteLine("het eerste stelsel is dus {0}a + {1}b = {2}",x1,y1,z1);
            x1 /= y1;
            z1 /= y1;
            y1 = 1 ;
            x1 = -x1;    
            Console.WriteLine("het omgevormde stelsel is dus b = {0}+({1}a)",z1,x1);

            double uitkomstbx1 = x1;
            double uitkomstbz1 = z1;
            Console.WriteLine("volgende stap is b vervangen bij tweede stelsel \n{0}a+({1})*({2}+({3}a))+({4})",x2,y2,z1,x1,Z2);
            z1 *= y2 ;
            x1 *= y2 ;
            Console.WriteLine("{0} is voor a {1}",x1,z1);
            // (x2a +x1a) (Z2 +z1) z omzetten
            x2 += x1;
            Z2 += z1;
            Z2 = -Z2;
            Console.WriteLine("de tussenuitkomst is {0}a = {1}", x2, Z2);
            uitkomstA = Z2 / x2;
            uitkomstB = uitkomstbx1 * uitkomstA + uitkomstbz1 ;
            Console.WriteLine("de uitkomsten zijn {0} voor a en {1} voor b", uitkomstA, uitkomstB);
        }
    }
}