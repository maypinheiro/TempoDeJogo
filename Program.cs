using System;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {

            var tempoDeJogo = Tela.RecebeValores();
            Calcular.HoraDeInicio(tempoDeJogo);
            Calcular.HoraDoFim(tempoDeJogo);
            tempoDeJogo.Intervalo = Calcular.Intervalo(tempoDeJogo.Inicio, tempoDeJogo.Final);
            tempoDeJogo.DuracaoHoras = Calcular.DuracaoHoras(tempoDeJogo.Intervalo);
            tempoDeJogo.DuracaoMinutos = Calcular.DuracaoMinutos(tempoDeJogo.Intervalo);
            Tela.ImprimiValor(tempoDeJogo.DuracaoHoras, tempoDeJogo.DuracaoMinutos);

        }
    }
}
