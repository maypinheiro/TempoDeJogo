using System;
using System.Collections.Generic;
using System.Text;

namespace TempoDeJogoComMinutos
{
    public static class Calcular
    {

        public static void HoraDeInicio(TempoDeJogo tempoDeJogo)
        {
            tempoDeJogo.Inicio = tempoDeJogo.HoraInicial * 60 + tempoDeJogo.MinutoInicial;

        }

        public static void HoraDoFim(TempoDeJogo tempoDeJogo)
        {
            tempoDeJogo.Final = tempoDeJogo.HoraFinal * 60 + tempoDeJogo.MinutoFinal;

        }

        public static int Intervalo(int inicio, int final)
        {
            int intervalo;

            if (inicio < final)
            {
                intervalo = final - inicio;
            }
            else
            {
                intervalo = (24 * 60 - inicio) + final;
            }

            return intervalo;
        }

        public static int DuracaoHoras(int intervalo)
        {
            return intervalo / 60;

        }

        public static int DuracaoMinutos(int intervalo)
        {

            return intervalo % 60;
        }

    }
}
