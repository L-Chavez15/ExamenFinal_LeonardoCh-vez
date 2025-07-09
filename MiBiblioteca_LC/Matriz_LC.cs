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

        Random r = new Random();

        public void CreacionL()
        {
            int col = 0;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionM()
        {
            int col = 1;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionMi()
        {
            int col = 2;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionJ()
        {
            int col = 3;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionV()
        {
            int col = 4;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionS()
        {
            int col = 5;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void CreacionD()
        {
            int col = 6;
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                int precios = r.Next(0, 21);
                espacios[i, col] = precios;
            }
        }
        public void mostrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ARTICULOS\t\tLUNES\t\tMARTES\t\tMIERCOLES\tJUEVES\t\tVIERNES\t\tSABADO\t\tDOMINGO");
            Console.ResetColor();
            for (int i = 0; i < espacios.GetLength(0); i++)
            {
                    Console.Write(" ARTICULO "+(i+1) + "\t");
                
                for (int j = 0; j < espacios.GetLength(1); j++)
                {
                    Console.Write("\t"+espacios[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
