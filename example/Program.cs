using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            do
            {
                Console.WriteLine("\n(X + Y * Z)/P");

               

                int X;
                Console.WriteLine("первое число равно");
                X = Convert.ToInt32(Console.ReadLine());

                int Y;
                Console.WriteLine("второе число равно");
                Y = Convert.ToInt32(Console.ReadLine());

                int Z;
                Console.WriteLine("третье число равно");
                Z = Convert.ToInt32(Console.ReadLine());

                double P;
                Console.WriteLine("четвертое число равно");
                P = Convert.ToInt32(Console.ReadLine());

                double
                    E = (X + Y * Z) / P;


                Console.WriteLine("\n({0} + {1} * {2})/{3} = ", X, Y, Z, P);
                Console.WriteLine("Результат : {0} \n", E);

                string ext = Console.ReadLine();
                if (ext == "exit")
                    break;

                Console.ReadKey();

                
            }
            while (true);
                       
        }
    
        
    }
    
}
