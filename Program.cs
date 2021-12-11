using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_aula_novembro
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("imforme o salario do funcionario: ");
            double slr_func = double.Parse(Console.ReadLine());

            Console.WriteLine("o funcionario possui filhos  (S/N) : ");
            string filhos = Console.ReadLine().ToUpper();

            if (filhos == "S") 
            {
                 slr_func += 200;
            }


            Console.WriteLine("o funcionario optou por plano de saude ?  (S/N)  ");
            string plano = Console.ReadLine().ToUpper();

            if (filhos == "S") 
            {
                 slr_func -= 300;

            }

            if (slr_func <= 4.000)
            {
                slr_func -= slr_func * 0.11;
            }
            else
            {
                slr_func -= slr_func * 0.15;
            }

            Console.WriteLine("o seu novo salrio sera de :" + slr_func.ToString("c"));
            Console.ReadLine();



        }   
    }
}
