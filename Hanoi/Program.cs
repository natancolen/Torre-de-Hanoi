using System;

namespace Hanoi
{
    class Program
    {
        /// <summary>
        /// Mover, método de mover os discos
        /// </summary>
        /// <param name="d">Quantidade de disco</param>
        /// <param name="ori">Torre de origem</param>
        /// <param name="dest">Torre de destino</param>
        /// <param name="aux">Torre auxiliar</param>
        static void Mover(int d, char ori, char dest, char aux)
        {
            if (d != 0)
            {
                Mover(d - 1, ori, aux, dest);
                Console.WriteLine("Move o disco " + d + " do " + ori + " para " + dest);
                Mover(d - 1, aux, dest, ori);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite valor: ");
            int valor = int.Parse(Console.ReadLine());

            Mover(valor, 'A', 'C', 'B');

            Console.ReadKey();
        }
    }
}
