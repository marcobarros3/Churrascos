using System;

namespace Churrascos

{
    class programa

    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.WriteLine("-- Churrasco --");
            Console.WriteLine("");

            Console.Write("Digite o número de Adultos que consomem bebidas alcólicas....:");
            int adultoConsome = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de Adulto que não consome bebida alcólicas...:");
            int adultoNConsome = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de crianças................................:");
            int criancas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......:{adultoConsome}");
            Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...:{adultoNConsome}");
            Console.WriteLine($"crianças .......................................:{criancas}");
            Console.WriteLine("");

                        double carneAd = 400, carneCr = 200, acomp = 200, cerv = 2, refri = 500, agua = 400;
            double totalCarne = (carneAd * (adultoConsome + adultoNConsome ) + (carneCr * criancas)) / 1000;

            
            double totalAcomp = (acomp *(adultoConsome + adultoNConsome + criancas)) / 1000;

                        double totalCerv = (cerv * adultoConsome );

            
            double totalRefri = (refri *(adultoNConsome + criancas)) / 1000;

            
             double totalAgua = (agua *(adultoConsome + adultoNConsome + criancas)) / 1000;

            Console.WriteLine($"Carne............: {totalCarne:n1} Kg");
            Console.WriteLine($"Acompanhamento...: {totalAcomp:n1} Kg");
            Console.WriteLine($"Cerveja..........: {totalCerv:n1} L");
            Console.WriteLine($"Refrigerante.....: {totalRefri:n1} L");
            Console.WriteLine($"Água.............: {totalAgua:n1} L");
        }
    }
}
