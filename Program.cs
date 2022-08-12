using System;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int inicio = horaInicial * 60 + minutoInicial;
            int final = horaFinal * 60 + minutoFinal;

            int tempoJogo;

            if (inicio < final)
            {
                tempoJogo = final - inicio;
            }
            else
            {
                tempoJogo = (24 * 60 - inicio) + final;
            }

            int duracaoHoras = tempoJogo / 60;
            int duracaoMinutos = tempoJogo % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
