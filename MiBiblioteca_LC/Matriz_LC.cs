using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiBiblioteca_LC
{
    public class Matriz_LC
    {
        int[,] espacios = new int[7,7];
        int[] articulos = new int[7];

        public void CreacionL()
        {
            Random r = new Random();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    espacios[i, j] = r.Next(0, 201);
                }
            }
        }
        public void mostrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ARTICULOS\tLUNES\t\tMARTES\t\tMIERCOLES\t\tJUEVES\t\tVIERNES\t\tSABADO\t\tDOMINGO");
            Console.ResetColor();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    Console.Write("\t\t"+espacios[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
