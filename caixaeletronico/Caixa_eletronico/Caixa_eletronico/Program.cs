using System;

namespace Caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int cedula1 = 0;
            int cedula2 = 0;
            int cedula5 = 0;
            int cedula10 = 0;
            int cedula20 = 0;
            int cedula50 = 0;
            int cedula100 = 0;
            int cedula200 = 0;

            Console.WriteLine("Digite o valor a ser sacado:");
            string cedulaSolicitado = Console.ReadLine();
            int cedula = Convert.ToInt32(cedulaSolicitado);

            int cedulaTemp = cedula;
            while (cedula > 0)
            {
                if (cedula >= 200)
                {
                    cedula -= 200;
                    cedula200++;
                }
                else if (cedula >= 100)
                {
                    cedula -= 100;
                    cedula100++;
                }
                else if (cedula >= 50)
                {
                    cedula -= 50;
                    cedula50++;
                }
                else if (cedula >= 20)
                {
                    cedula -= 20;
                    cedula20++;
                }
                else if (cedula >= 10)
                {
                    cedula -= 10;
                    cedula10++;
                }
                else if (cedula >= 5)
                {
                    cedula -= 5;
                    cedula5++;
                }
                else if (cedula >= 2)
                {
                    cedula -= 2;
                    cedula2++;
                }
                else if (cedula >= 1)
                {
                    cedula -= 1;
                    cedula1++;
                }
            }

if (cedula1 != 0)
{
    Console.WriteLine("Cedula de 1,00: " + cedula1);
}
if (cedula2 != 0)
{
    Console.WriteLine("Cedula de 2,00: " + cedula2);
}
if (cedula5 != 0)
{
    Console.WriteLine("Cedula de 5,00: " + cedula5);
}
if (cedula10 != 0)
{
    Console.WriteLine("Cedula de 10,00: " + cedula10);
}
if (cedula20 != 0)
{
    Console.WriteLine("Cedula de 20,00: " + cedula20);
}
if (cedula50 != 0)
{
    Console.WriteLine("Cedula de 50,00: " + cedula50);
}
if (cedula100 != 0)
{
    Console.WriteLine("Cedula de 100,00: " + cedula100);
}
if (cedula200 != 0)
{
    Console.WriteLine("Cedula de 200,00: " + cedula200);
}
  }      
 }   
}
