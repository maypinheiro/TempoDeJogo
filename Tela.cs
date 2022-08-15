using System;
using System.Collections.Generic;
using System.Text;

namespace TempoDeJogoComMinutos
{
    public static class Tela
    {
        public static TempoDeJogo RecebeValores()
        {

            TempoDeJogo tempoDeJogo = new TempoDeJogo();
            string[] valores = Console.ReadLine().Split(' ');

            tempoDeJogo.HoraInicial = int.Parse(valores[0]);
            tempoDeJogo.MinutoInicial = int.Parse(valores[1]);
            tempoDeJogo.HoraFinal = int.Parse(valores[2]);
            tempoDeJogo.MinutoFinal = int.Parse(valores[3]);

            return tempoDeJogo;

        }

        public static void ImprimiValor(int duracaoHoras, int duracaoMinutos)
        {
            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
        }
    }
}
